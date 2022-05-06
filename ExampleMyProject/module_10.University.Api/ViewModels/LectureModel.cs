using System.Collections.Generic;
using module_10.University.Domain.Attendances;

namespace module_10.University.Api.ViewModels
{
    public class LectureModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int LecturerId { get; set; }
        
        public List<AttendanceModel> Attendances { get; set; }
    }
}