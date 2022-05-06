using AutoMapper;
using module_10.University.Api.ViewModels;
using module_10.University.Domain.Attendances;
using module_10.University.Domain.Lecturers;
using module_10.University.Domain.Lectures;
using module_10.University.Domain.Students;

namespace module_10.University.Api.Configuration
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<Attendance, AttendanceModel>().ReverseMap();
            CreateMap<Lecturer, LecturerModel>().ReverseMap();
            CreateMap<Lecture, LectureModel>().ReverseMap();
            CreateMap<Student, StudentModel>().ReverseMap();
        }
    }
}