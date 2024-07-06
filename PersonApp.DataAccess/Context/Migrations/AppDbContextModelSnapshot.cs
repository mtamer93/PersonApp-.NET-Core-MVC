﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonApp.DataAccess.Context;

#nullable disable

namespace PersonApp.DataAccess.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonApp.Core.Entities.Concrete.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Person", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4706),
                            DateOfBirth = new DateTime(1993, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mehmet.yilmaz@deneme.com",
                            FirstName = "Mehmet",
                            LastName = "Yılmaz",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4719),
                            DateOfBirth = new DateTime(1986, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmet.erdogan@deneme.com",
                            FirstName = "Ahmet",
                            LastName = "Erdoğan",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4721),
                            DateOfBirth = new DateTime(1960, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sevinc.tamer@deneme.com",
                            FirstName = "Sevinç",
                            LastName = "Tamer",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4723),
                            DateOfBirth = new DateTime(2000, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fatih.ozturk@deneme.com",
                            FirstName = "Fatih",
                            LastName = "Öztürk",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4724),
                            DateOfBirth = new DateTime(2004, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "merve.dogan@deneme.com",
                            FirstName = "Merve",
                            LastName = "Doğan",
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
