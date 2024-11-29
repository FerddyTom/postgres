﻿// <auto-generated />
using DemoEntity.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoEntity.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241129065828_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoEntity.Entities.Jutsu", b =>
                {
                    b.Property<int>("JutsuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JutsuId"));

                    b.Property<string>("JutsuDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JutsuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JutsuId");

                    b.ToTable("Jutsus");
                });
#pragma warning restore 612, 618
        }
    }
}
