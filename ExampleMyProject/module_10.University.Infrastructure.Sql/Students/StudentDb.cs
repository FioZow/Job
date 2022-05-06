namespace module_10.University.Infrastructure.Sql.Students
{
    public class StudentDb : IBaseEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
    }
}