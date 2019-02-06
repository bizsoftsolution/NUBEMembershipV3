﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NUBE.DAL;

namespace NUBE.Server.Migrations
{
    [DbContext(typeof(NUBEMembershipDBContext))]
    [Migration("20190130091721_Bank Branch")]
    partial class BankBranch
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NUBE.DAL.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("NUBE.DAL.BankBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("BankId");

                    b.Property<int>("CityId");

                    b.Property<string>("Code");

                    b.Property<string>("EMailId");

                    b.Property<bool>("IsHeadOffice");

                    b.Property<string>("Name");

                    b.Property<int>("OrganisationBranchDetailId");

                    b.Property<string>("PostalCode");

                    b.Property<string>("PrimaryPhoneNo");

                    b.Property<string>("SecondaryPhoneNo");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("CityId");

                    b.HasIndex("OrganisationBranchDetailId");

                    b.ToTable("BankBranches");
                });

            modelBuilder.Entity("NUBE.DAL.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("NUBE.DAL.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("NUBE.DAL.OrganisationBranchDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("organisationBranchDetails");
                });

            modelBuilder.Entity("NUBE.DAL.OrganisationDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("PostalCode");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("OrganisationDetails");
                });

            modelBuilder.Entity("NUBE.DAL.PersonTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PersonTitles");
                });

            modelBuilder.Entity("NUBE.DAL.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("NUBE.DAL.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("NUBE.DAL.BankBranch", b =>
                {
                    b.HasOne("NUBE.DAL.Bank", "Bank")
                        .WithMany("BankBranches")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NUBE.DAL.City", "City")
                        .WithMany("BankBranches")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NUBE.DAL.OrganisationBranchDetail", "OrganisationBranchDetail")
                        .WithMany("BankBranches")
                        .HasForeignKey("OrganisationBranchDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NUBE.DAL.City", b =>
                {
                    b.HasOne("NUBE.DAL.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NUBE.DAL.OrganisationDetail", b =>
                {
                    b.HasOne("NUBE.DAL.City", "City")
                        .WithMany("OrganisationDetails")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NUBE.DAL.State", b =>
                {
                    b.HasOne("NUBE.DAL.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}