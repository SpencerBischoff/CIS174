using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentsBischoff.Models
{
    public class StudentView : DbContext
    {
        public string Title;
        public List<string> Students;
        public StudentView(DbContextOptions<StudentView> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { FirstName = "Spencer", LastName = "Bischoff", Grade = 86 },
                new Student { FirstName = "Rebecca", LastName = "Lynn", Grade = 93 },
                new Student { FirstName = "James", LastName = "Rivers", Grade = 72 },
                new Student { FirstName = "Kelly", LastName = "Ann", Grade = 89 },
                new Student { FirstName = "Jimmy", LastName = "Lackers", Grade = 81 }
                );
        }
    }
}
