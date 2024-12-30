﻿// <auto-generated />
using Catalyst4Change.ApiService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalyst4Change.ApiService.Migrations
{
    [DbContext(typeof(Catalyst4ChangeDBContext))]
    partial class Catalyst4ChangeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Catalyst4Change.ApiService.Data.NGO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NGOAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NGOName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("WorkingSectors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NGOList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NGOAddress = "BOLANGIR, ORISSA https://www.odishanews24.in, RUGUDIPARA NEAR TELEPHONE EXCHANGE OFFICE BALANGIR",
                            NGOName = "PRERANA",
                            RegistrationNumber = "6301-41",
                            WorkingSectors = "[\"Agriculture\",\"Animal Husbandry, Dairying \\u0026 Fisheries\",\"Art \\u0026 Culture\",\"Children\",\"Differently Abled\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Aged/Elderly\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Human Rights\",\"Information \\u0026 Communication Technology\",\"Labour \\u0026 Employment\",\"Micro Small \\u0026 Medium Enterprises\",\"New \\u0026 Renewable Energy\",\"Panchayati Raj\",\"Scientific \\u0026 Industrial Research\",\"Water Resources\",\"Women\\u0027s Development \\u0026 Empowerment\"]"
                        },
                        new
                        {
                            Id = 2,
                            NGOAddress = "Port Blair, ANDAMAN & NICOBAR ISLANDS http://arpan.ngo.tripod.com, ARPAN Enem Post Ograbraj",
                            NGOName = "ARPAN",
                            RegistrationNumber = "1316",
                            WorkingSectors = "[\"Aged/Elderly\",\"Agriculture\",\"Art \\u0026 Culture\",\"Children\",\"Civic Issues\",\"Differently Abled\",\"Disaster Management\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Housing\",\"Human Rights\",\"Information \\u0026 Communication Technology\",\"Legal Awareness \\u0026 Aid\",\"Micro Finance (SHGs)\",\"Minority Issues\",\"Micro Small \\u0026 Medium Enterprises\",\"Nutrition\",\"Panchayati Raj\",\"Right to Information \\u0026 Advocacy\",\"Rural Development \\u0026 Poverty Alleviation\",\"Sports\"]"
                        },
                        new
                        {
                            Id = 3,
                            NGOAddress = "Narela, DELHI, 65, Pana Udyan, Narela, Delhi - 110040",
                            NGOName = "Pragya Network Educational Society",
                            RegistrationNumber = "S-52559",
                            WorkingSectors = "[\"Aged/Elderly\",\"Agriculture\",\"Art \\u0026 Culture\",\"Children\",\"Civic Issues\",\"Differently Abled\",\"Disaster Management\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Housing\",\"Micro Finance (SHGs)\",\"Nutrition\",\"Panchayati Raj\",\"Rural Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Urban Development \\u0026 Poverty Alleviation\",\"Vocational Training\",\"Water Resources\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Youth Affairs\",\"Minority Issues\",\"Food Processing\",\"Information \\u0026 Communication Technology\",\"Labour \\u0026 Employment\",\"New \\u0026 Renewable Energy\"]"
                        },
                        new
                        {
                            Id = 4,
                            NGOAddress = "Aizawl, MIZORAM, N7-11, H Chhawntluanga Bldg, Durtlang Road, Bawngkawn, Aizawl-796 014 Mizoram",
                            NGOName = "Save Help and Develop S H A D E",
                            RegistrationNumber = "S.R. - 77/97/MZ-RFS of 1997",
                            WorkingSectors = "[\"HIV/AIDS\",\"Tribal Affairs\"]"
                        },
                        new
                        {
                            Id = 5,
                            NGOAddress = "Jaipur, RAJASTHAN, http://www.cecoedecon.org.in, F-159-160, Institutional",
                            NGOName = "Centre for Community Economics and Development Consultants Society",
                            RegistrationNumber = "206",
                            WorkingSectors = "[\"Animal Husbandry, Dairying \\u0026 Fisheries\",\"Agriculture\",\"Disaster Management\",\"Drinking Water\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"Micro Finance (SHGs)\",\"Minority Issues\",\"Civic Issues\",\"Dalit Upliftment\",\"Education \\u0026 Literacy\",\"Human Rights\",\"Land Resources\",\"Legal Awareness \\u0026 Aid\",\"Nutrition\",\"Panchayati Raj\",\"Right to Information \\u0026 Advocacy\",\"Rural Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Urban Development \\u0026 Poverty Alleviation\",\"Vocational Training\",\"Water Resources\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Agriculture\"]"
                        },
                        new
                        {
                            Id = 6,
                            NGOAddress = "TIRUCHULI, TAMIL NADU, http://www.odamindia.org, 197, WEST CAR STREET TIRUCHULI-626129",
                            NGOName = "ODAM",
                            RegistrationNumber = "43/1995",
                            WorkingSectors = "[\"Aged/Elderly\",\"Agriculture\",\"Biotechnology\",\"Children\",\"Differently Abled\",\"Disaster Management\",\"Dalit Upliftment\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Housing\",\"Human Rights\",\"Micro Finance (SHGs)\",\"Minority Issues\",\"Micro Small \\u0026 Medium Enterprises\",\"New \\u0026 Renewable Energy\",\"Nutrition\",\"Scientific \\u0026 Industrial Research\",\"Science \\u0026 Technology\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Legal Awareness \\u0026 Aid\",\"Rural Development \\u0026 Poverty Alleviation\"]"
                        },
                        new
                        {
                            Id = 7,
                            NGOAddress = "South Delhi, DELHI, http://haryali.org.in, Plot No. 14, 2nd Floor, Zakir Nagar West, New Delhi-110025",
                            NGOName = "HARYALI CENTRE FOR RURAL DEVELOPMENT",
                            RegistrationNumber = "S-29712",
                            WorkingSectors = "[\"Aged/Elderly\",\"Agriculture\",\"Children\",\"Differently Abled\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Micro Finance (SHGs)\",\"Nutrition\",\"Panchayati Raj\",\"Rural Development \\u0026 Poverty Alleviation\",\"Urban Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\"]"
                        },
                        new
                        {
                            Id = 8,
                            NGOAddress = "SUNDERNAGAR, HIMACHAL PRADESH, Pungh Sundernagar Distt. Mandi (HP)",
                            NGOName = "OPEN EDUCATIONAL DEVELOPMENT RESEARCH AND WELFARE",
                            RegistrationNumber = "126/2004",
                            WorkingSectors = "[\"Art \\u0026 Culture\",\"Biotechnology\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Information \\u0026 Communication Technology\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\"]"
                        },
                        new
                        {
                            Id = 9,
                            NGOAddress = "Bhopal, MADHYA PRADESH, https://www.cardindia.org/, H-2/195, ARVIND VIHAR, BAGMUGALIA, BHOPAL",
                            NGOName = "Centre for Advanced Research and Development",
                            RegistrationNumber = "25634",
                            WorkingSectors = "[\"Any Other\",\"Agriculture\",\"Animal Husbandry, Dairying \\u0026 Fisheries\",\"Children\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Land Resources\",\"Panchayati Raj\",\"Rural Development \\u0026 Poverty Alleviation\",\"Science \\u0026 Technology\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Dalit Upliftment\",\"Tourism\",\"Water Resources\",\"Skill Development\"]"
                        },
                        new
                        {
                            Id = 10,
                            NGOAddress = "Chakradharpur, JHARKHAND, http://www.smvmngo.org, Nargis Manzil, Bangla Tand, Ward No 12 PO - Chakradharpur",
                            NGOName = "Srijan Mahila Vikas Manch",
                            RegistrationNumber = "363",
                            WorkingSectors = "[\"Agriculture\",\"Children\",\"Differently Abled\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Micro Finance (SHGs)\",\"Nutrition\",\"Prisoner\\u0027s Issues\",\"Rural Development \\u0026 Poverty Alleviation\",\"Urban Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Youth Affairs\"]"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
