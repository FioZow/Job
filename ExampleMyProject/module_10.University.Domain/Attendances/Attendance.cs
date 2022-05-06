namespace module_10.University.Domain.Attendances
{
    public class Attendance
    {
        public int Id { get; set; }

        public int LectureId { get; set; }

        public int StudentId { get; set; }

        public bool HasVisited { get; set; }

        public int Mark { get; set; }
    }
}