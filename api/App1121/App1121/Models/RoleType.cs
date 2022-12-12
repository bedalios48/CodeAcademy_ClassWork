namespace App1121.Models
{
    public class RoleType
    {
        public RoleType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<LocalUser> LocalUsers { get; set; }
    }
}
