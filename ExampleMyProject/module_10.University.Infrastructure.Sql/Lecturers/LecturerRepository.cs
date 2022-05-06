using AutoMapper;
using module_10.University.Domain.Lecturers;

namespace module_10.University.Infrastructure.Sql.Lecturers
{
    public class LecturerRepository : BaseRepository<Lecturer, LecturerDb>, ILecturerRepository
    {
        public LecturerRepository(CustomDbContext context, IMapper mapper) : base(context, mapper, context.Lecturers)
        {
        }
    }
}