using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameWrokCore.Models
{
    public partial class EntityFrameWorkContext : DbContext
    {

        public EntityFrameWorkContext()
        {
        }

        public EntityFrameWorkContext(DbContextOptions<EntityFrameWorkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
        public virtual DbSet<TblLogin> TblLogin { get; set; }
        public virtual DbSet<TblMovie> TblMovie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=LAPTOP-IK5KB9U4\\SQLEXPRESS;database=EntityFrameWork;trusted_connection=yes");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__tblEmplo__AF4CE865301FF21B");

                entity.ToTable("tblEmployee");

                entity.Property(e => e.Empid)
                    .HasColumnName("empid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Empcity)
                    .HasColumnName("empcity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empemail)
                    .HasColumnName("empemail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empname)
                    .HasColumnName("empname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emppass)
                    .HasColumnName("emppass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empsalary).HasColumnName("empsalary");
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblLogin");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passcode)
                    .HasColumnName("passcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMovie>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK__tblMovie__DF5032EC27123122");

                entity.ToTable("tblMovie");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Mbooking).HasColumnName("mbooking");

                entity.Property(e => e.Mdate)
                    .HasColumnName("mdate")
                    .HasColumnType("date");

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mtype)
                    .HasColumnName("mtype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
