namespace module_10.University.Infrastructure.Sql.Lecturers
{
    public class LecturerDb : IBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}