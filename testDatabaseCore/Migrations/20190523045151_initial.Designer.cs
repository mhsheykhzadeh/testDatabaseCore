﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testDatabaseCore.DAL;

namespace testDatabaseCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190523045151_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("testDatabaseCore.Models.Core.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchCode");

                    b.Property<string>("CompanyTitle")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int?>("CompanyTypeId");

                    b.Property<string>("Description")
                        .HasMaxLength(150);

                    b.Property<string>("EconomicalNumber")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<string>("NationalNumber");

                    b.Property<int?>("ParentId");

                    b.Property<string>("RegistrationNumber")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CompanyTypeId");

                    b.HasIndex("ParentId");

                    b.ToTable("Company","Cor");
                });

            modelBuilder.Entity("testDatabaseCore.Models.Core.CompanyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("CompanyType","Cor");
                });

            modelBuilder.Entity("testDatabaseCore.Models.Core.Company", b =>
                {
                    b.HasOne("testDatabaseCore.Models.Core.CompanyType", "CompanyType")
                        .WithMany("Companies")
                        .HasForeignKey("CompanyTypeId");

                    b.HasOne("testDatabaseCore.Models.Core.Company", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}