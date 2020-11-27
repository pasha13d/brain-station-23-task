﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCP.Context;

namespace SCP.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCP.Model.PostDetails", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.Property<string>("Admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id", "PostsId");

                    b.HasIndex("PostsId");

                    b.ToTable("PostDetails");
                });

            modelBuilder.Entity("SCP.Model.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SCP.Model.PostDetails", b =>
                {
                    b.HasOne("SCP.Model.Posts", "Posts")
                        .WithMany("PostDetails")
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
