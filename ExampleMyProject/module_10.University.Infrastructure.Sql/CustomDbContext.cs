using Microsoft.EntityFrameworkCore;
using module_10.University.Infrastructure.Sql.Attendances;
using module_10.University.Infrastructure.Sql.Lecturers;
using module_10.University.Infrastructure.Sql.Lectures;
using module_10.University.Infrastructure.Sql.Students;

namespace module_10.University.Infrastructure.Sql
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
        {
        }

        public DbSet<StudentDb> Students { get; set; }
        public DbSet<AttendanceDb> Attendances { get; set; }
        public DbSet<LecturerDb> Lecturers { get; set; }
        public DbSet<LectureDb> Lectures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LectureDb>(l =>
            {
                l.HasOne<LecturerDb>()
                    .WithMany()
                    .HasForeignKey(p => p.LecturerId);

                // l.HasMany<AttendanceDb>()
                //     .WithOne()
                //     .HasForeignKey(x => x.LectureId);
            });

            modelBuilder.Entity<AttendanceDb>()
                .HasOne<StudentDb>()
                .WithMany()
                .HasForeignKey(x => x.StudentId);

            modelBuilder.Entity<AttendanceDb>()
                .HasOne(p => p.Lecture)
                .WithMany(b => b.Attendances)
                .HasForeignKey(x => x.LectureId);
        }
    }
}