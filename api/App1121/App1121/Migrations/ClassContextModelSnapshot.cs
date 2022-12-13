﻿// <auto-generated />
using System;
using App1121.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App1121.Migrations
{
    [DbContext(typeof(ClassContext))]
    partial class ClassContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App1121.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Astrid Lindgren",
                            Cover = "Hardcover",
                            PublishYear = 1969,
                            Quantity = 0,
                            Title = "Pippi Longstocking"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Astrid Lindgren",
                            Cover = "Paperback",
                            PublishYear = 1955,
                            Quantity = 0,
                            Title = "Karlsson on the Roof"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Astrid Lindgren",
                            Cover = "Electronic",
                            PublishYear = 1970,
                            Quantity = 0,
                            Title = "Emil of Lonneberga"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Astrid Lindgren",
                            Cover = "Electronic",
                            PublishYear = 1990,
                            Quantity = 0,
                            Title = "The Children of Troublemaker Street"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Jo Nesbo",
                            Cover = "Hardcover",
                            PublishYear = 1997,
                            Quantity = 0,
                            Title = "The Bat"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jo Nesbo",
                            Cover = "Paperback",
                            PublishYear = 2002,
                            Quantity = 0,
                            Title = "Nemesis"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Stieg Larsson",
                            Cover = "Hardcover",
                            PublishYear = 2005,
                            Quantity = 0,
                            Title = "The Girl with the Dragon Tattoo"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Stieg Larsson",
                            Cover = "Electronic",
                            PublishYear = 2006,
                            Quantity = 0,
                            Title = "The Girl Who Played with Fire"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Stieg Larsson",
                            Cover = "Paperback",
                            PublishYear = 2007,
                            Quantity = 0,
                            Title = "The Girl Who Kicked the Hornet's Nest"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Hans Christian Andersen",
                            Cover = "Paperback",
                            PublishYear = 1836,
                            Quantity = 0,
                            Title = "The Little Mermaid"
                        });
                });

            modelBuilder.Entity("App1121.Models.BorrowedBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BorrowTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("App1121.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("App1121.Models.RoleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Customer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tester"
                        });
                });

            modelBuilder.Entity("App1121.Models.BorrowedBook", b =>
                {
                    b.HasOne("App1121.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App1121.Models.LocalUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("App1121.Models.LocalUser", b =>
                {
                    b.HasOne("App1121.Models.RoleType", "Role")
                        .WithMany("LocalUsers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("App1121.Models.RoleType", b =>
                {
                    b.Navigation("LocalUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
