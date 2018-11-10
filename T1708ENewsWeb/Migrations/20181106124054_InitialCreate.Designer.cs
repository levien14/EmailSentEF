﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T1708ENewsWeb.Models;

namespace T1708ENewsWeb.Migrations
{
    [DbContext(typeof(T1708ENewsWebContext))]
    [Migration("20181106124054_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("T1708ENewsWeb.Models.Mark", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentRollNumber");

                    b.Property<int>("SubjectMark");

                    b.Property<string>("SubjectName");

                    b.HasKey("id");

                    b.HasIndex("StudentRollNumber");

                    b.ToTable("Marks");

                    b.HasData(
                        new { id = 1, StudentRollNumber = "D00597", SubjectMark = 30, SubjectName = "Java" },
                        new { id = 2, StudentRollNumber = "D00597", SubjectMark = 20, SubjectName = "C#" },
                        new { id = 3, StudentRollNumber = "D00597", SubjectMark = 40, SubjectName = "HTML" },
                        new { id = 4, StudentRollNumber = "D00598", SubjectMark = 45, SubjectName = "Java" },
                        new { id = 5, StudentRollNumber = "D00598", SubjectMark = 28, SubjectName = "C#" },
                        new { id = 6, StudentRollNumber = "D00598", SubjectMark = 30, SubjectName = "HTML" },
                        new { id = 7, StudentRollNumber = "D0600", SubjectMark = 30, SubjectName = "Java" }
                    );
                });

            modelBuilder.Entity("T1708ENewsWeb.Models.Student", b =>
                {
                    b.Property<string>("RollNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("RollNumber");

                    b.ToTable("Student");

                    b.HasData(
                        new { RollNumber = "D00597", CreateAt = new DateTime(2018, 11, 6, 19, 40, 54, 231, DateTimeKind.Local), Email = "Vienlvd00597@fpt.edu.vn", FirstName = "Vien", LastName = "Le", Status = 1, UpdateAt = new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) },
                        new { RollNumber = "D00598", CreateAt = new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local), Email = "TuanLc00598@fpt.edu.vn", FirstName = "Luu Cung", LastName = "Tuan", Status = 1, UpdateAt = new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) },
                        new { RollNumber = "D0600", CreateAt = new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local), Email = "HaiddD600@fpt.edu.vn", FirstName = "Dai", LastName = "Hai", Status = 1, UpdateAt = new DateTime(2018, 11, 6, 19, 40, 54, 232, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("T1708ENewsWeb.Models.Mark", b =>
                {
                    b.HasOne("T1708ENewsWeb.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentRollNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
