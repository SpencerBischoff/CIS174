using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Models
{   
    /***************************************************************
    * Name        : StudentContext
    * Author      : Spencer Bischoff
    * Created     : 10/1/2020
    ***************************************************************/
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Spencer", LastName = "Bischoff", Grade = 86 },
                new Student { StudentId = 2, FirstName = "Rebecca", LastName = "Lynn", Grade = 93 },
                new Student { StudentId = 3, FirstName = "James", LastName = "Rivers", Grade = 72 },
                new Student { StudentId = 4, FirstName = "Kelly", LastName = "Ann", Grade = 89 },
                new Student { StudentId = 5, FirstName = "Jimmy", LastName = "Lackers", Grade = 81 }
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=tcp:cis174bischoff.database.windows.net,1433;Initial Catalog=Students;Persist Security Info=False;User ID=spencer;Password=gAu33uXWVctn;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
