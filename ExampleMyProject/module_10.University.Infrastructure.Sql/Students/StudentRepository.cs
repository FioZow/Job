using AutoMapper;
using module_10.University.Domain.Students;

namespace module_10.University.Infrastructure.Sql.Students
{
    public class StudentRepository : BaseRepository<Student, StudentDb>, IStudentRepository
    {
        public StudentRepository(CustomDbContext context, IMapper mapper) : base(context, mapper, context.Students)
        {
        }
    }
}