﻿// <auto-generated />
using System;
using LBGDBMetadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LBGDBMetadata.Migrations
{
    [DbContext(typeof(MetaDataContext))]
    partial class MetaDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("LBGDBMetadata.LaunchBox.Metadata.Game", b =>
                {
                    b.Property<long>("DatabaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("CommunityRating")
                        .HasColumnType("TEXT");

                    b.Property<long>("CommunityRatingCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Developer")
                        .HasColumnType("TEXT");

                    b.Property<string>("ESRB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platform")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("WikipediaURL")
                        .HasColumnType("TEXT");

                    b.HasKey("DatabaseID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LBGDBMetadata.LaunchBox.Metadata.GameAlternateName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlternateName")
                        .HasColumnType("TEXT");

                    b.Property<long>("DatabaseID")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("GameDatabaseID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("GameDatabaseID");

                    b.ToTable("GameAlternateName");
                });

            modelBuilder.Entity("LBGDBMetadata.LaunchBox.Metadata.GameImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("DatabaseID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<long?>("GameDatabaseID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("GameDatabaseID");

                    b.ToTable("GameImages");
                });

            modelBuilder.Entity("LBGDBMetadata.LaunchBox.Metadata.GameAlternateName", b =>
                {
                    b.HasOne("LBGDBMetadata.LaunchBox.Metadata.Game", "Game")
                        .WithMany("AlternateNames")
                        .HasForeignKey("GameDatabaseID");
                });

            modelBuilder.Entity("LBGDBMetadata.LaunchBox.Metadata.GameImage", b =>
                {
                    b.HasOne("LBGDBMetadata.LaunchBox.Metadata.Game", "Game")
                        .WithMany("Images")
                        .HasForeignKey("GameDatabaseID");
                });
#pragma warning restore 612, 618
        }
    }
}
