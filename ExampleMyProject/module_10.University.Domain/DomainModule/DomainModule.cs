using Autofac;
using module_10.University.Domain.Attendances;
using module_10.University.Domain.Lecturers;
using module_10.University.Domain.Lectures;
using module_10.University.Domain.Students;

namespace module_10.University.Domain.DomainModule
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentFacade>().As<IStudentFacade>();
            builder.RegisterType<LecturerFacade>().As<ILecturerFacade>();
            builder.RegisterType<LectureFacade>().As<ILectureFacade>();
            builder.RegisterType<AttendanceFacade>().As<IAttendanceFacade>();
        }
    }
}