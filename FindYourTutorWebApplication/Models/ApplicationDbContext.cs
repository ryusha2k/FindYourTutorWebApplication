using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Arrangement> Arrangements { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arrangement>().ToTable("Arrangement");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Tutor>().ToTable("Tutor");
            modelBuilder.Entity<User>().ToTable("User");

            modelBuilder.Entity<Tutor>().HasMany(x => x.Subjects).WithMany(x => x.Tutors).UsingEntity(j => j.ToTable("SubjectTutor"));
        }
    }
}
