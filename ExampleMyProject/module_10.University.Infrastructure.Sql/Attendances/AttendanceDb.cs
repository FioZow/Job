using module_10.University.Infrastructure.Sql.Lectures;

namespace module_10.University.Infrastructure.Sql.Attendances
{
    public class AttendanceDb : IBaseEntity
    {
        public int Id { get; set; }

        public int LectureId { get; set; }

        public int StudentId { get; set; }

        public bool HasVisited { get; set; }

        public int Mark { get; set; }

        public virtual LectureDb Lecture { get; set; }
    }
}