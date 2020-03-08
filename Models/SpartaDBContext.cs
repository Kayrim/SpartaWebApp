using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpartaWebApp.Models
{
    public partial class SpartaDBContext : DbContext
    {
        public SpartaDBContext()
        {
        }

        public SpartaDBContext(DbContextOptions<SpartaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<TrainerCourses> TrainerCourses { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CatgeoryId).HasColumnName("CatgeoryID");

                entity.Property(e => e.CourseDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CourseName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LengthOfCourse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catgeory)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.CatgeoryId)
                    .HasConstraintName("FK__Course__Catgeory__276EDEB3");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Project__Student__2D27B809");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Bio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Student__CourseI__2A4B4B5E");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.Property(e => e.Bio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainerCourses>(entity =>
            {
                entity.HasKey(e => e.Tcid)
                    .HasName("PK__TrainerC__B773707F6E84A432");

                entity.Property(e => e.Tcid).HasColumnName("TCID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TrainerCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__TrainerCo__Cours__300424B4");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.TrainerCourses)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK__TrainerCo__Train__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
