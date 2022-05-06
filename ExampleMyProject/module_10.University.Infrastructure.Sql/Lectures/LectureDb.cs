using System.Collections.Generic;
using module_10.University.Infrastructure.Sql.Attendances;

namespace module_10.University.Infrastructure.Sql.Lectures
{
    public class LectureDb : IBaseEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int LecturerId { get; set; }
        
        public IList<AttendanceDb> Attendances { get; set; }
    }
}