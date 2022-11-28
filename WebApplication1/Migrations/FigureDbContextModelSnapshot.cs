﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.Database;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(FigureDbContext))]
    partial class FigureDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Figures.Circle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Area")
                        .HasColumnType("double precision");

                    b.Property<int>("CenterId")
                        .HasColumnType("integer");

                    b.Property<double>("Perimeter")
                        .HasColumnType("double precision");

                    b.Property<double>("Radius")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Circles");
                });

            modelBuilder.Entity("WebApplication1.Figures.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CircleId")
                        .HasColumnType("integer");

                    b.Property<double>("CoordinateX")
                        .HasColumnType("double precision");

                    b.Property<double>("CoordinateY")
                        .HasColumnType("double precision");

                    b.Property<int?>("RectangleId")
                        .HasColumnType("integer");

                    b.Property<int?>("SquareId")
                        .HasColumnType("integer");

                    b.Property<int?>("TriangleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CircleId");

                    b.HasIndex("RectangleId");

                    b.HasIndex("SquareId");

                    b.HasIndex("TriangleId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("WebApplication1.Figures.Rectangle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Area")
                        .HasColumnType("double precision");

                    b.Property<int>("CenterId")
                        .HasColumnType("integer");

                    b.Property<double>("Perimeter")
                        .HasColumnType("double precision");

                    b.Property<double>("SideA")
                        .HasColumnType("double precision");

                    b.Property<double>("SideB")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Rectangles");
                });

            modelBuilder.Entity("WebApplication1.Figures.Square", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Area")
                        .HasColumnType("double precision");

                    b.Property<int>("CenterId")
                        .HasColumnType("integer");

                    b.Property<double>("Perimeter")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Squares");
                });

            modelBuilder.Entity("WebApplication1.Figures.Triangle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Area")
                        .HasColumnType("double precision");

                    b.Property<int>("CenterId")
                        .HasColumnType("integer");

                    b.Property<double>("Perimeter")
                        .HasColumnType("double precision");

                    b.Property<double>("SideA")
                        .HasColumnType("double precision");

                    b.Property<double>("SideB")
                        .HasColumnType("double precision");

                    b.Property<double>("SideC")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Triangles");
                });

            modelBuilder.Entity("WebApplication1.Figures.Circle", b =>
                {
                    b.HasOne("WebApplication1.Figures.Point", "Center")
                        .WithMany()
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("WebApplication1.Figures.Point", b =>
                {
                    b.HasOne("WebApplication1.Figures.Circle", null)
                        .WithMany("Points")
                        .HasForeignKey("CircleId");

                    b.HasOne("WebApplication1.Figures.Rectangle", null)
                        .WithMany("Points")
                        .HasForeignKey("RectangleId");

                    b.HasOne("WebApplication1.Figures.Square", null)
                        .WithMany("Points")
                        .HasForeignKey("SquareId");

                    b.HasOne("WebApplication1.Figures.Triangle", null)
                        .WithMany("Points")
                        .HasForeignKey("TriangleId");
                });

            modelBuilder.Entity("WebApplication1.Figures.Rectangle", b =>
                {
                    b.HasOne("WebApplication1.Figures.Point", "Center")
                        .WithMany()
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("WebApplication1.Figures.Square", b =>
                {
                    b.HasOne("WebApplication1.Figures.Point", "Center")
                        .WithMany()
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("WebApplication1.Figures.Triangle", b =>
                {
                    b.HasOne("WebApplication1.Figures.Point", "Center")
                        .WithMany()
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("WebApplication1.Figures.Circle", b =>
                {
                    b.Navigation("Points");
                });

            modelBuilder.Entity("WebApplication1.Figures.Rectangle", b =>
                {
                    b.Navigation("Points");
                });

            modelBuilder.Entity("WebApplication1.Figures.Square", b =>
                {
                    b.Navigation("Points");
                });

            modelBuilder.Entity("WebApplication1.Figures.Triangle", b =>
                {
                    b.Navigation("Points");
                });
#pragma warning restore 612, 618
        }
    }
}
