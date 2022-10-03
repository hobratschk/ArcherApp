﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221002221617_UpdateEventARepoAndController")]
    partial class UpdateEventARepoAndController
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("API.Entities.Archer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Archers");
                });

            modelBuilder.Entity("API.Entities.EventAScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArcherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArcherName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TargetA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetB")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetE")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetF")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("EventAScores");
                });

            modelBuilder.Entity("API.Entities.EventBScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArcherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetB")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetE")
                        .HasColumnType("INTEGER");

                    b.Property<float>("TimePenalty")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ArcherId");

                    b.ToTable("EventBScores");
                });

            modelBuilder.Entity("API.Entities.EventBScore", b =>
                {
                    b.HasOne("API.Entities.Archer", "Archer")
                        .WithMany()
                        .HasForeignKey("ArcherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archer");
                });
#pragma warning restore 612, 618
        }
    }
}
