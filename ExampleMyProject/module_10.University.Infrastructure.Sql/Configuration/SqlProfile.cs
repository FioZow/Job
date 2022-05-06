using AutoMapper;
using module_10.University.Domain.Attendances;
using module_10.University.Domain.Lecturers;
using module_10.University.Domain.Lectures;
using module_10.University.Domain.Students;
using module_10.University.Infrastructure.Sql.Attendances;
using module_10.University.Infrastructure.Sql.Lecturers;
using module_10.University.Infrastructure.Sql.Lectures;
using module_10.University.Infrastructure.Sql.Students;

namespace module_10.University.Infrastructure.Sql.Configuration
{
    public class SqlProfile : Profile
    {
        public SqlProfile()
        {
            CreateMap<Attendance, AttendanceDb>().ReverseMap();
            CreateMap<Lecturer, LecturerDb>().ReverseMap();
            CreateMap<Lecture, LectureDb>().ReverseMap();
            CreateMap<Student, StudentDb>().ReverseMap();
        }
    }
}