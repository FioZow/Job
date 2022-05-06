using System.Collections.Generic;

namespace module_10.University.Domain.Attendances
{
    public interface IAttendanceRepository
    {
        void Create(Attendance attendance);
        
        Attendance Get(int id);
        
        List<Attendance> GetByStudentId(int studentId);

        void Update(Attendance attendance);

        void Delete(int id);
    }
}