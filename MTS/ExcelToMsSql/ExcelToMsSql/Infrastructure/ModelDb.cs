using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ExcelToMsSql.Infrastructure
{
    public partial class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }

        public virtual DbSet<Mts> Mts { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mts>()
                .Property(e => e.district)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.first_stage_manager)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.contractor_for_1_task)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.object_number)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.object_number_db)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.placement_equipment_A)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.accessory_equipment_A)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.note_for_2_task)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.access_permission_note_for_3_task)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.name_KA)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.note_for_4_task)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.menager_of_4_task)
                .IsUnicode(false);

            modelBuilder.Entity<Mts>()
                .Property(e => e.executor_of_2_and_3_tasks)
                .IsUnicode(false);
        }
    }
}
