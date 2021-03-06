﻿// <auto-generated />
using System;
using Blog_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog_project.Migrations
{
    [DbContext(typeof(BlogDBContext))]
    [Migration("20210114121037_buba1")]
    partial class buba1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Blog_project.Models.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("postId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Blog_project.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Blog_project.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("publishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Blog_project.Models.Comment", b =>
                {
                    b.HasOne("Blog_project.Models.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog_project.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
