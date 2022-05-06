using AutoMapper;
using module_10.University.Domain.Lectures;

namespace module_10.University.Infrastructure.Sql.Lectures
{
    public class LectureRepository : BaseRepository<Lecture, LectureDb>, ILectureRepository
    {
        public LectureRepository(CustomDbContext context, IMapper mapper) : base(context, mapper, context.Lectures)
        {
        }
    }
}