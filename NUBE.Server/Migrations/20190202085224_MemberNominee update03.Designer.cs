﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NUBE.DAL;

namespace NUBE.Server.Migrations
{
    [DbContext(typeof(NUBEMembershipDBContext))]
    [Migration("20190202085224_MemberNominee update03")]
    partial class MemberNomineeupdate03
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

            modelBuilder.Entity("NUBE.DAL.ENumData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ENumTypeId");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ENumTypeId");

                    b.ToTable("ENumDatas");
                });

            modelBuilder.Entity("NUBE.DAL.ENumType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ENumTypes");
                });

            modelBuilder.Entity("NUBE.DAL.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("DOB");

                    b.Property<DateTime>("DOE");

                    b.Property<DateTime>("DOJ");

                    b.Property<string>("EMailId");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Levy")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<decimal>("LevyAmount");

                    b.Property<string>("MemberName");

                    b.Property<string>("MemberNo");

                    b.Property<string>("MemberType")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("MobileNo");

                    b.Property<string>("NRIC_N");

                    b.Property<string>("NRIC_O");

                    b.Property<int>("PersonTitleId");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<bool>("ReJoin");

                    b.Property<decimal>("Salary");

                    b.Property<string>("TDF")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<decimal>("TDFAmount");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("NUBE.DAL.MemberNominee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int>("MemberId");

                    b.Property<string>("MobileNo");

                    b.Property<string>("NRIC_N");

                    b.Property<string>("NRIC_O");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("PostalCode");

                    b.Property<int?>("RelationshipId");

                    b.Property<int>("RelatonshipId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("RelationshipId");

                    b.ToTable("MemberNominees");
                });

            modelBuilder.Entity("NUBE.DAL.OrganisationBranchDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OrganisationBranchDetails");
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

            modelBuilder.Entity("NUBE.DAL.ENumData", b =>
                {
                    b.HasOne("NUBE.DAL.ENumType", "ENumType")
                        .WithMany("ENumDatas")
                        .HasForeignKey("ENumTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NUBE.DAL.Member", b =>
                {
                    b.HasOne("NUBE.DAL.City", "City")
                        .WithMany("Members")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NUBE.DAL.MemberNominee", b =>
                {
                    b.HasOne("NUBE.DAL.Member", "Member")
                        .WithMany("MemberNominees")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NUBE.DAL.Relationship", "Relationship")
                        .WithMany("MemberNominees")
                        .HasForeignKey("RelationshipId");
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
