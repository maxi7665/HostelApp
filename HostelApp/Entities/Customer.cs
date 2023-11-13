namespace HostelApp.Entities
{
    public class Customer : Entity
    {
        public string FullName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }
    }
}
