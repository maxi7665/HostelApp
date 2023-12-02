using HostelApp.Entities;
using System.Text.Json;

namespace HostelApp.Persistence
{
    public partial class BaseDbContext
    {
        private string _databaseFullFileName = string.Empty;

        private RootScheme? _scheme;

        public void SetDatabaseFullFileName(string databaseFullFileName)
        {
            _databaseFullFileName = databaseFullFileName;
        }

        public string GetDatabaseFullFileName() => _databaseFullFileName;

        public Task SelectDatabaseFile()
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.CheckFileExists = false;

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _databaseFullFileName = openFileDialog.FileName;
                _scheme = null;
            }            

            return Task.CompletedTask;
        }

        public async Task ClearDatabaseFile()
        {
            var fileName = GetDatabaseFullFileName();

            File.Delete(fileName);

            await InitDatabase();

            _scheme = null;

            await FetchData();
        }

        public async Task CopyDatabaseFile()
        {
            await SaveChanges();

            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.CheckFileExists = false;

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var saveFileName = openFileDialog.FileName;

                File.Copy(GetDatabaseFullFileName(), saveFileName);
            }
        }

        private Task InitDatabase()
        {
            var data = new RootScheme();

            using var fileStream = new FileStream(_databaseFullFileName, FileMode.Create);

            JsonSerializer.Serialize(fileStream, data);

            return Task.CompletedTask;
        }

        private async Task<RootScheme> FetchData()
        {
            if (_scheme == null)
            {
                if (!File.Exists(_databaseFullFileName)
                    || new FileInfo(_databaseFullFileName).Length == 0)
                {
                    await InitDatabase();
                }

                using var fileStream = new FileStream(_databaseFullFileName, FileMode.Open);

                _scheme = JsonSerializer.Deserialize<RootScheme>(fileStream)
                    ?? throw new NullReferenceException();
            }

            return _scheme;
        }

        

        private async Task<List<T>> GetEntities<T>() where T : Entity
        {
            var scheme = await FetchData();

            foreach (var prop in scheme.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(List<T>))
                {
                    return ((List<T>)prop.GetValue(scheme)!)
                        .OrderBy(e => e.Id)
                        .ToList();
                }
            }

            throw new NullReferenceException();
        }

        private async Task UpdateEntities<T>(List<T> entities) where T : Entity
        {
            var scheme = await FetchData();

            foreach (var prop in scheme.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(List<T>))
                {
                    prop.SetValue(scheme, entities);
                }
            }
        }

        private async Task<T?> GetEntity<T>(int id) where T : Entity
        {
            var entities = await GetEntities<T>();

            var entity = entities.Where(e => e.Id == id).FirstOrDefault();

            return entity;
        }

        private async Task UpdateEntity<T>(T entity) where T : Entity
        {
            var entities = await GetEntities<T>();

            var toUpdate = entities.Where(e => e.Id == entity.Id).FirstOrDefault()
                ?? throw new KeyNotFoundException();

            var removed = entities.Remove(toUpdate);

            if (!removed)
            {
                throw new ApplicationException("Remove");
            }

            entities.Add(entity);

            await UpdateEntities(entities);
        }

        private async Task AddEntity<T>(T entity) where T : Entity
        {
            var entities = await GetEntities<T>();

            if (entity.Id != 0)
            {
                var existing = entities.Where(e => e.Id == entity.Id).FirstOrDefault();

                if (existing != null)
                {
                    throw new ApplicationException("Duplicate key");
                }
            }
            else
            {
                var data = await GetEntities<T>();

                var lastEntity = data.MaxBy(e => e.Id);

                entity.Id = (lastEntity?.Id ?? 0) + 1;
            }            

            entities.Add(entity);

            await UpdateEntities(entities);
        }

        private async Task DeleteEntity<T>(int id) where T : Entity
        {
            var scheme = await FetchData();

            foreach (var prop in scheme.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(List<T>))
                {
                    var entities = prop.GetValue(scheme) as List<T> 
                        ?? throw new NullReferenceException();

                    var removed = entities.RemoveAll(e => e.Id == id);

                    if (removed == 0)
                    {
                        throw new ApplicationException("Can't remove");
                    }
                }
            }
        }

        public async Task SaveChanges()
        {
            await SaveData();
        }

        private Task SaveData()
        {
            using var fileStream = new FileStream(
                _databaseFullFileName,
                FileMode.Open,
                FileAccess.Write);

            JsonSerializer.Serialize(fileStream, _scheme);

            return Task.CompletedTask;
        }

        public WorkingSession BeginSession() => new WorkingSession(this);

        public class WorkingSession : IDisposable
        {
            private readonly BaseDbContext _baseDbContext;

            public WorkingSession(BaseDbContext baseDbContext)
            {
                this._baseDbContext = baseDbContext;
            }

            public void Dispose()
            {
                _baseDbContext.SaveChanges().Wait();
            }
        }
    }
}
