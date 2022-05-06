using System.Collections.Generic;
using module_10.University.Domain.Attendances;

namespace module_10.University.Domain.Lectures
{
    public class Lecture
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int LecturerId { get; set; }
        
        public List<Attendance> Attendances { get; set; }
    }
}