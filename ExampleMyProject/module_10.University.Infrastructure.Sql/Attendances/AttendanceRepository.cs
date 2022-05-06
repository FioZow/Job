using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using module_10.University.Domain.Attendances;

namespace module_10.University.Infrastructure.Sql.Attendances
{
    public class AttendanceRepository : BaseRepository<Attendance, AttendanceDb>, IAttendanceRepository
    {
        private readonly DbSet<AttendanceDb> _dbSet;
        
        private readonly IMapper _mapper;

        public AttendanceRepository(CustomDbContext context, IMapper mapper) : base(context, mapper,
            context.Attendances)
        {
            _mapper = mapper;
            _dbSet = context.Attendances;
        }

        public List<Attendance> GetByStudentId(int studentId)
        {
            var entities = _dbSet.AsNoTracking().Where(x => x.StudentId == studentId).ToList();
            return _mapper.Map<List<Attendance>>(entities);
        }
    }
}