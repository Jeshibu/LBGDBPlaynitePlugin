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
#pragma warning restore 612, 618
        }
    }
}
