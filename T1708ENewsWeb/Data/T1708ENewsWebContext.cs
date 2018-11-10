using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace T1708ENewsWeb.Models
{
    public class T1708ENewsWebContext : DbContext
    {
        public T1708ENewsWebContext(DbContextOptions<T1708ENewsWebContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany<Mark>(s => s.Marks)
                .WithOne(m => m.Student)
                .HasForeignKey(x => x.StudentRollNumber)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    RollNumber = "D00597",
                    LastName = "Le",
                    FirstName = "Vien",
                    Email = "Vienlvd00597@fpt.edu.vn"
                },
                    new Student()
                    {
                        RollNumber = "D00598",
                        LastName = "Tuan",
                        FirstName = "Luu Cung",
                        Email = "TuanLc00598@fpt.edu.vn"
                    },
                    new Student()
                    {
                        RollNumber = "D0600",
                        LastName = "Hai",
                        FirstName = "Dai",
                        Email = "HaiddD600@fpt.edu.vn"
                    }
                );
            modelBuilder.Entity<Mark>().HasData(
                new Mark()
                {
                    id = 1,
                    SubjectName = "Java",
                    SubjectMark = 30,
                    StudentRollNumber = "D00597"
                },
                 new Mark()
                 {
                     id = 2,
                     SubjectName = "C#",
                     SubjectMark = 20,
                     StudentRollNumber = "D00597"
                 },
                  new Mark()
                  {
                      id = 3,
                      SubjectName = "HTML",
                      SubjectMark = 40,
                      StudentRollNumber = "D00597"
                  },
                   new Mark()
                   {
                       id = 4,
                       SubjectName = "Java",
                       SubjectMark = 45,
                       StudentRollNumber = "D00598"
                   },
                    new Mark()
                    {
                        id = 5,
                        SubjectName = "C#",
                        SubjectMark = 28,
                        StudentRollNumber = "D00598"
                    },
                     new Mark()
                     {
                         id = 6,
                         SubjectName = "HTML",
                         SubjectMark = 30,
                         StudentRollNumber = "D00598"
                     },
                      new Mark()
                      {
                          id = 7,
                          SubjectName = "Java",
                          SubjectMark = 30,
                          StudentRollNumber = "D0600"
                      }
                                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<T1708ENewsWeb.Models.Student> Student { get; set; }
        public DbSet<T1708ENewsWeb.Models.Mark> Marks { get; set; }
    }
}
