﻿// <auto-generated />
using ManyToManyEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManyToManyEF.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230718133305_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookUser", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("BookUser");
                });

            modelBuilder.Entity("ManyToManyEF.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "O'tkan kunlar"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ikki eshik orasi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chinor"
                        });
                });

            modelBuilder.Entity("ManyToManyEF.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hr bo'limi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Moliya bo'limi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "O'quv bo'limi"
                        });
                });

            modelBuilder.Entity("ManyToManyEF.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rustam",
                            StaffId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dilmurod",
                            StaffId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sanjar",
                            StaffId = 2
                        });
                });

            modelBuilder.Entity("BookUser", b =>
                {
                    b.HasOne("ManyToManyEF.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManyToManyEF.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManyToManyEF.Models.User", b =>
                {
                    b.HasOne("ManyToManyEF.Models.Staff", "Staff")
                        .WithMany("Users")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("ManyToManyEF.Models.Staff", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}