namespace module_10.University.Domain.Attendances
{
    public interface IAttendanceFacade
    {
        void Create(Attendance attendance);
        
        Attendance Get(int id);

        void Update(Attendance attendance);

        void Delete(int id);
    }
}