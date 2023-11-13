using HostelApp.Entities;
using System.Text.Json;

namespace HostelApp.Persistence
{
    public class BaseDbContext
    {
        private string _databaseFullFileName = string.Empty;

        public void SetDatabaseFullFileName(string databaseFullFileName)
        {
            _databaseFullFileName = databaseFullFileName;
        }

        public string GetDatabaseFullFileName() => _databaseFullFileName;

        public async Task SelectDatabaseFile()
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.CheckFileExists = false;

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _databaseFullFileName = openFileDialog.FileName;
            }

            await InitDatabase();
        }

        private async Task InitDatabase()
        {
            var data = new RootScheme();

            using var fileStream = new FileStream(_databaseFullFileName, FileMode.Create);

            await JsonSerializer.SerializeAsync(fileStream, data);
        }

        private async Task<RootScheme> FetchData()
        {
            using var fileStream = new FileStream(_databaseFullFileName, FileMode.Open);

            RootScheme scheme = await JsonSerializer.DeserializeAsync<RootScheme>(fileStream)
                ?? throw new NullReferenceException();

            return scheme;
        }

        private async Task SaveData(RootScheme scheme)
        {
            using var fileStream = new FileStream(
                _databaseFullFileName,
                FileMode.Open,
                FileAccess.Write);

            await JsonSerializer.SerializeAsync(fileStream, scheme);
        }

        private async Task<List<T>> GetEntities<T>() where T : Entity
        {
            var scheme = await FetchData();

            foreach (var prop in scheme.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(List<T>))
                {
                    return (List<T>)prop.GetValue(scheme)!;
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

            await SaveData(scheme);
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

            var existing = entities.Where(e => e.Id == entity.Id).FirstOrDefault();

            if (existing != null)
            {
                throw new ApplicationException("Duplicate key");
            }

            entities.Add(entity);

            await UpdateEntities(entities);
        }
    }
}
