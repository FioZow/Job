using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace module_10.University.Infrastructure.Sql
{
    public abstract class BaseRepository<TEntity, TBaseEntity> where TBaseEntity : class, IBaseEntity
    {
        private readonly DbContext _context;

        private readonly IMapper _mapper;

        private readonly DbSet<TBaseEntity> _dbSet;

        public BaseRepository(DbContext context, IMapper mapper, DbSet<TBaseEntity> dbSet)
        {
            _context = context;
            _mapper = mapper;
            _dbSet = dbSet;
        }

        public void Create(TEntity entity)
        {
            var entityDb = _mapper.Map<TBaseEntity>(entity);
            _dbSet.Add(entityDb);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var entityDb = _mapper.Map<TBaseEntity>(entity);
            entityDb = GetFromDb(entityDb);
            _mapper.Map(entity, entityDb);
            _context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            var entityDb = _dbSet.SingleOrDefault(x => x.Id == id);
            var entity = _mapper.Map<TEntity>(entityDb);
            return entity;
        }

        public void Delete(int id)
        {
            _dbSet.Remove(_dbSet.SingleOrDefault(x => x.Id == id));
            _context.SaveChanges();
        }

        private TBaseEntity GetFromDb(TBaseEntity baseEntity) =>
            _dbSet.SingleOrDefault(x => x.Id == baseEntity.Id);
    }
}