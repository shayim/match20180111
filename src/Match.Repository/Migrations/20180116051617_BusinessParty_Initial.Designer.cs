﻿// <auto-generated />
using Match.Domain.Common.Business;
using Match.Domain.Common.PartyBase;
using Match.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Match.Repository.Migrations
{
    [DbContext(typeof(BusinessPartyDbContext))]
    [Migration("20180116051617_BusinessParty_Initial")]
    partial class BusinessParty_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Match.Domain.BusinessParties.Client", b =>
                {
                    b.Property<Guid>("Id");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Match.Domain.BusinessParties.ClientSalesPerson", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<Guid>("SalesPersonId");

                    b.Property<bool>("IsActive");

                    b.HasKey("ClientId", "SalesPersonId");

                    b.HasIndex("SalesPersonId");

                    b.ToTable("ClientSalesPerson");
                });

            modelBuilder.Entity("Match.Domain.Common.Business.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Match.Domain.Common.Business.Employee", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("EmployeeNum")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("Match.Domain.Common.Business.EmploymentContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EffectiveFrom");

                    b.Property<DateTime?>("EffectiveTo");

                    b.Property<Guid>("EmployeeId");

                    b.Property<string>("FileUrl")
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Num")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmploymentContract");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CityId");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("DistrictId");

                    b.Property<int?>("StateProvinceId");

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("StateProvinceId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("StateProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateProvinceId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContinentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.StateProvince", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("StateProvince");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.ZipCode", b =>
                {
                    b.Property<int>("CityId");

                    b.Property<string>("Code")
                        .HasMaxLength(10);

                    b.Property<int?>("CountryId");

                    b.Property<int?>("DistrictId");

                    b.Property<int?>("ProvinceId");

                    b.Property<int?>("StateProvinceId");

                    b.HasKey("CityId", "Code");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("StateProvinceId");

                    b.ToTable("ZipCode");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.AddressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("AddressType");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("ParentBankId");

                    b.Property<string>("SwiftCode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ParentBankId");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.BankAccount", b =>
                {
                    b.Property<Guid>("PartyId");

                    b.Property<int>("BankId");

                    b.Property<string>("AccountNumber")
                        .HasMaxLength(50);

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("PartyId", "BankId", "AccountNumber");

                    b.HasIndex("BankId");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.BusinessSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("BusinessSection");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Currency", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.HasKey("Code");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.IdentityDocument", b =>
                {
                    b.Property<Guid>("PartyId");

                    b.Property<int>("TypeId");

                    b.Property<string>("Num")
                        .HasMaxLength(50);

                    b.Property<DateTime>("EffectiveFrom");

                    b.Property<DateTime?>("EffectiveTo");

                    b.Property<string>("FileUrl")
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.HasKey("PartyId", "TypeId", "Num");

                    b.HasIndex("TypeId");

                    b.ToTable("IdentityDocument");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.IdentityDocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("PartyType");

                    b.HasKey("Id");

                    b.ToTable("IdentityDocumentType");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Party", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<int>("PartyType");

                    b.Property<string>("Tel")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Party");

                    b.HasDiscriminator<int>("PartyType");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.PartyAddress", b =>
                {
                    b.Property<Guid>("PartyId");

                    b.Property<int>("AddressId");

                    b.Property<int>("AddressTypeId");

                    b.HasKey("PartyId", "AddressId");

                    b.HasIndex("AddressId");

                    b.HasIndex("AddressTypeId");

                    b.ToTable("PartyAddress");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.PartyContact", b =>
                {
                    b.Property<Guid>("PartyId");

                    b.Property<Guid>("ContactId");

                    b.Property<bool>("IsActive");

                    b.HasKey("PartyId", "ContactId");

                    b.HasIndex("ContactId");

                    b.ToTable("PartyContact");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.SocialMediaAccount", b =>
                {
                    b.Property<Guid>("PersonId");

                    b.Property<int>("SocialMediaTypeId");

                    b.Property<string>("Account")
                        .HasMaxLength(50);

                    b.HasKey("PersonId", "SocialMediaTypeId", "Account");

                    b.HasIndex("SocialMediaTypeId");

                    b.ToTable("SocialMediaAccount");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.SocialMediaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("SocialMediaType");
                });

            modelBuilder.Entity("Match.Domain.BusinessParties.SalesPerson", b =>
                {
                    b.HasBaseType("Match.Domain.Common.Business.Employee");

                    b.Property<int>("SalesPersonType");

                    b.ToTable("SalesPerson");

                    b.HasDiscriminator().HasValue("SalesPerson");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Company", b =>
                {
                    b.HasBaseType("Match.Domain.Common.PartyBase.Party");

                    b.Property<int?>("BusinessSectionId");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasIndex("BusinessSectionId");

                    b.ToTable("Company");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Person", b =>
                {
                    b.HasBaseType("Match.Domain.Common.PartyBase.Party");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .HasMaxLength(20);

                    b.Property<int?>("NationalityId");

                    b.HasIndex("NationalityId");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Match.Domain.BusinessParties.Client", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.Party", "Party")
                        .WithOne()
                        .HasForeignKey("Match.Domain.BusinessParties.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.BusinessParties.ClientSalesPerson", b =>
                {
                    b.HasOne("Match.Domain.BusinessParties.Client", "Client")
                        .WithMany("CurrentSalesPersons")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Match.Domain.BusinessParties.SalesPerson", "SalesPerson")
                        .WithMany("Clients")
                        .HasForeignKey("SalesPersonId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Match.Domain.Common.Business.Employee", b =>
                {
                    b.HasOne("Match.Domain.Common.Business.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.PartyBase.Person", "Person")
                        .WithOne()
                        .HasForeignKey("Match.Domain.Common.Business.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.Business.EmploymentContract", b =>
                {
                    b.HasOne("Match.Domain.Common.Business.Employee")
                        .WithMany("EmploymentContracts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.Address", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Match.Domain.Common.Geolocations.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Match.Domain.Common.Geolocations.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("Match.Domain.Common.Geolocations.StateProvince", "StateProvince")
                        .WithMany()
                        .HasForeignKey("StateProvinceId");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.City", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.Geolocations.StateProvince")
                        .WithMany("Cities")
                        .HasForeignKey("StateProvinceId");
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.District", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.StateProvince", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.Country")
                        .WithMany("StateProvinces")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.Geolocations.ZipCode", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.City")
                        .WithMany("ZipCodes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.Geolocations.Country")
                        .WithMany("ZipCodes")
                        .HasForeignKey("CountryId");

                    b.HasOne("Match.Domain.Common.Geolocations.District")
                        .WithMany("ZipCodes")
                        .HasForeignKey("DistrictId");

                    b.HasOne("Match.Domain.Common.Geolocations.StateProvince")
                        .WithMany("ZipCodes")
                        .HasForeignKey("StateProvinceId");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Bank", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.Bank", "ParentBank")
                        .WithMany("SubBranches")
                        .HasForeignKey("ParentBankId");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.BankAccount", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.PartyBase.Party")
                        .WithMany("BankAccounts")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.IdentityDocument", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.Party")
                        .WithMany("IdentityDocuments")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.PartyBase.IdentityDocumentType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.PartyAddress", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.PartyBase.AddressType", "Type")
                        .WithMany()
                        .HasForeignKey("AddressTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.PartyBase.Party")
                        .WithMany("Addresses")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.PartyContact", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.Party", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Match.Domain.Common.PartyBase.Party", "Party")
                        .WithMany("Contacts")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.SocialMediaAccount", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.Person")
                        .WithMany("SocialMediaAccounts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Match.Domain.Common.PartyBase.SocialMediaType", "SocialMediaType")
                        .WithMany()
                        .HasForeignKey("SocialMediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Company", b =>
                {
                    b.HasOne("Match.Domain.Common.PartyBase.BusinessSection", "BusinessSection")
                        .WithMany()
                        .HasForeignKey("BusinessSectionId");
                });

            modelBuilder.Entity("Match.Domain.Common.PartyBase.Person", b =>
                {
                    b.HasOne("Match.Domain.Common.Geolocations.Country", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");
                });
#pragma warning restore 612, 618
        }
    }
}
