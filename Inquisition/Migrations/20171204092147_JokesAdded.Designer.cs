﻿// <auto-generated />
using Inquisition.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Inquisition.Migrations
{
    [DbContext(typeof(InquisitionContext))]
    [Migration("20171204092147_JokesAdded")]
    partial class JokesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inquisition.Data.Game", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<string>("Args");

                    b.Property<string>("ExeDir");

                    b.Property<bool>("IsOnline");

                    b.Property<string>("Port")
                        .HasMaxLength(10);

                    b.Property<string>("Version")
                        .HasMaxLength(10);

                    b.HasKey("Name");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Inquisition.Data.Joke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("NegativeVotes");

                    b.Property<int>("PositiveVotes");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Jokes");
                });

            modelBuilder.Entity("Inquisition.Data.Reminder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Reminders");
                });
#pragma warning restore 612, 618
        }
    }
}