﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PineBerry_0._0._1.DataContext;

namespace PineBerry_0._0._1.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PineBerry_0._0._1.Models.Admin", b =>
                {
                    b.Property<int>("AdminNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SuperAdmin")
                        .HasColumnType("bit");

                    b.HasKey("AdminNo");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PineBerry_0._0._1.Models.Berry", b =>
                {
                    b.Property<int>("BerriesNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubjectNo")
                        .HasColumnType("int");

                    b.HasKey("BerriesNo");

                    b.HasIndex("SubjectNo");

                    b.ToTable("Berries");
                });

            modelBuilder.Entity("PineBerry_0._0._1.Models.Notice", b =>
                {
                    b.Property<int>("NoticeNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NoticeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoticeNo");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("PineBerry_0._0._1.Models.QnA", b =>
                {
                    b.Property<int>("QnANo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("QuestionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QnANo");

                    b.ToTable("QnAs");
                });

            modelBuilder.Entity("PineBerry_0._0._1.Models.Subject", b =>
                {
                    b.Property<int>("SubjectNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectNo");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("PineBerry_0._0._1.Models.Berry", b =>
                {
                    b.HasOne("PineBerry_0._0._1.Models.Subject", "SubjectName")
                        .WithMany()
                        .HasForeignKey("SubjectNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
