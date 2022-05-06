using System.Linq;
using module_10.University.Domain.DomainNotificationService;
using module_10.University.Domain.Exceptions;

namespace module_10.University.Domain.Attendances
{
    public class AttendanceFacade : IAttendanceFacade
    {
        private readonly IAttendanceRepository _repository;
        private readonly INotificationService _notificationService;

        public AttendanceFacade(IAttendanceRepository repository, INotificationService notificationService)
        {
            _repository = repository;
            _notificationService = notificationService;
        }

        public void Create(Attendance attendance)
        {
            ValidateMarkAttendance(attendance);
            _repository.Create(attendance);
            CheckStudentAttendances(attendance.StudentId);
            
        }

        public void Update(Attendance attendance)
        {
            ValidateMarkAttendance(attendance);
            _repository.Update(attendance);
            CheckStudentAttendances(attendance.StudentId);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Attendance Get(int id) => _repository.Get(id);

        private void ValidateMarkAttendance(Attendance attendance)
        {
            if (!attendance.HasVisited)
            {
                attendance.Mark = 0;
            }
            
            if (attendance.Mark < 0 && attendance.Mark > 5)
            {
                throw new InvalidMarkException();
            }
        }

        private void CheckStudentAttendances(int studentId)
        {
            var attendances = _repository.GetByStudentId(studentId);

            if (attendances.Count(x => !x.HasVisited) > 3)
            {
                _notificationService.SendEmail("Missed 3 Lectures");
            }

            if (attendances.Average(x => x.Mark) < 4)
            {
                _notificationService.SendSms("Your average mark is less than 4");
            }
        }
    }
}