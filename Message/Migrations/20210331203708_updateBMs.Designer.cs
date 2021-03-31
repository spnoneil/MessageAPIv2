﻿// <auto-generated />
using System;
using Message.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Message.Migrations
{
    [DbContext(typeof(MessageContext))]
    [Migration("20210331203708_updateBMs")]
    partial class updateBMs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Message.Models.BMessage", b =>
                {
                    b.Property<int>("BMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Posted")
                        .HasColumnType("datetime(6)");

                    b.HasKey("BMessageId");

                    b.HasIndex("GroupId");

                    b.ToTable("BMessages");
                });

            modelBuilder.Entity("Message.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Message.Models.BMessage", b =>
                {
                    b.HasOne("Message.Models.Group", null)
                        .WithMany("BMessages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Message.Models.Group", b =>
                {
                    b.Navigation("BMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
