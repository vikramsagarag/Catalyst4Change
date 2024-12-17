using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Catalyst4Change.ApiService.Data
{
    public class Catalyst4ChangeDBContext : DbContext
    {
        public Catalyst4ChangeDBContext(DbContextOptions<Catalyst4ChangeDBContext> options) : base(options)
        {
        }

        public DbSet<NGO> NGOList => Set<NGO>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NGO>().HasData(
                new NGO
                {
                    Id = 1,
                    NGOName = "PRERANA",
                    RegistrationNumber = "6301-41",
                    NGOAddress = "BOLANGIR, ORISSA https://www.odishanews24.in, RUGUDIPARA NEAR TELEPHONE EXCHANGE OFFICE BALANGIR",
                    WorkingSectors = new List<string>
                    {
                        "Agriculture",
                        "Animal Husbandry, Dairying & Fisheries",
                        "Art & Culture",
                        "Children",
                        "Differently Abled",
                        "Drinking Water",
                        "Education & Literacy",
                        "Aged/Elderly",
                        "Environment & Forests",
                        "Food Processing",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Human Rights",
                        "Information & Communication Technology",
                        "Labour & Employment",
                        "Micro Small & Medium Enterprises",
                        "New & Renewable Energy",
                        "Panchayati Raj",
                        "Scientific & Industrial Research",
                        "Water Resources",
                        "Women's Development & Empowerment"
                    }
                },
                new NGO
                {
                    Id = 2,
                    NGOName = "ARPAN",
                    RegistrationNumber = "1316",
                    NGOAddress = "Port Blair, ANDAMAN & NICOBAR ISLANDS http://arpan.ngo.tripod.com, ARPAN Enem Post Ograbraj",
                    WorkingSectors = new List<string>
                    {
                        "Aged/Elderly",
                        "Agriculture",
                        "Art & Culture",
                        "Children",
                        "Civic Issues",
                        "Differently Abled",
                        "Disaster Management",
                        "Drinking Water",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Food Processing",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Housing",
                        "Human Rights",
                        "Information & Communication Technology",
                        "Legal Awareness & Aid",
                        "Micro Finance (SHGs)",
                        "Minority Issues",
                        "Micro Small & Medium Enterprises",
                        "Nutrition",
                        "Panchayati Raj",
                        "Right to Information & Advocacy",
                        "Rural Development & Poverty Alleviation",
                        "Sports"
                    }
                },
                new NGO
                {
                    Id = 3,
                    NGOName = "Pragya Network Educational Society",
                    RegistrationNumber = "S-52559",
                    NGOAddress = "Narela, DELHI, 65, Pana Udyan, Narela, Delhi - 110040",
                    WorkingSectors = new List<string>
                    {
                        "Aged/Elderly",
                        "Agriculture",
                        "Art & Culture",
                        "Children",
                        "Civic Issues",
                        "Differently Abled",
                        "Disaster Management",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Housing",
                        "Micro Finance (SHGs)",
                        "Nutrition",
                        "Panchayati Raj",
                        "Rural Development & Poverty Alleviation",
                        "Tribal Affairs",
                        "Urban Development & Poverty Alleviation",
                        "Vocational Training",
                        "Water Resources",
                        "Women's Development & Empowerment",
                        "Youth Affairs",
                        "Minority Issues",
                        "Food Processing",
                        "Information & Communication Technology",
                        "Labour & Employment",
                        "New & Renewable Energy"
                    }
                },
                new NGO
                {
                    Id = 4,
                    NGOName = "Save Help and Develop S H A D E",
                    RegistrationNumber = "S.R. - 77/97/MZ-RFS of 1997",
                    NGOAddress = "Aizawl, MIZORAM, N7-11, H Chhawntluanga Bldg, Durtlang Road, Bawngkawn, Aizawl-796 014 Mizoram",
                    WorkingSectors = new List<string>
                    {
                        "HIV/AIDS",
                        "Tribal Affairs"
                    }
                },
                new NGO
                {
                    Id = 5,
                    NGOName = "Centre for Community Economics and Development Consultants Society",
                    RegistrationNumber = "206",
                    NGOAddress = "Jaipur, RAJASTHAN, http://www.cecoedecon.org.in, F-159-160, Institutional",
                    WorkingSectors = new List<string>
                    {
                        "Animal Husbandry, Dairying & Fisheries",
                        "Agriculture",
                        "Disaster Management",
                        "Drinking Water",
                        "Environment & Forests",
                        "Food Processing",
                        "Health & Family Welfare",
                        "Micro Finance (SHGs)",
                        "Minority Issues",
                        "Civic Issues",
                        "Dalit Upliftment",
                        "Education & Literacy",
                        "Human Rights",
                        "Land Resources",
                        "Legal Awareness & Aid",
                        "Nutrition",
                        "Panchayati Raj",
                        "Right to Information & Advocacy",
                        "Rural Development & Poverty Alleviation",
                        "Tribal Affairs",
                        "Urban Development & Poverty Alleviation",
                        "Vocational Training",
                        "Water Resources",
                        "Women's Development & Empowerment",
                        "Agriculture"
                    }
                },
                new NGO
                {
                    Id = 6,
                    NGOName = "ODAM",
                    RegistrationNumber = "43/1995",
                    NGOAddress = "TIRUCHULI, TAMIL NADU, http://www.odamindia.org, 197, WEST CAR STREET TIRUCHULI-626129",
                    WorkingSectors = new List<string>
                    {
                        "Aged/Elderly",
                        "Agriculture",
                        "Biotechnology",
                        "Children",
                        "Differently Abled",
                        "Disaster Management",
                        "Dalit Upliftment",
                        "Drinking Water",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Food Processing",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Housing",
                        "Human Rights",
                        "Micro Finance (SHGs)",
                        "Minority Issues",
                        "Micro Small & Medium Enterprises",
                        "New & Renewable Energy",
                        "Nutrition",
                        "Scientific & Industrial Research",
                        "Science & Technology",
                        "Tribal Affairs",
                        "Vocational Training",
                        "Women's Development & Empowerment",
                        "Legal Awareness & Aid",
                        "Rural Development & Poverty Alleviation"
                    }
                },
                new NGO
                {
                    Id = 7,
                    NGOName = "HARYALI CENTRE FOR RURAL DEVELOPMENT",
                    RegistrationNumber = "S-29712",
                    NGOAddress = "South Delhi, DELHI, http://haryali.org.in, Plot No. 14, 2nd Floor, Zakir Nagar West, New Delhi-110025",
                    WorkingSectors = new List<string>
                    {
                        "Aged/Elderly",
                        "Agriculture",
                        "Children",
                        "Differently Abled",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Micro Finance (SHGs)",
                        "Nutrition",
                        "Panchayati Raj",
                        "Rural Development & Poverty Alleviation",
                        "Urban Development & Poverty Alleviation",
                        "Tribal Affairs",
                        "Vocational Training",
                        "Women's Development & Empowerment"
                    }
                },
                new NGO
                {
                    Id = 8,
                    NGOName = "OPEN EDUCATIONAL DEVELOPMENT RESEARCH AND WELFARE",
                    RegistrationNumber = "126/2004",
                    NGOAddress = "SUNDERNAGAR, HIMACHAL PRADESH, Pungh Sundernagar Distt. Mandi (HP)",
                    WorkingSectors = new List<string>
                    {
                        "Art & Culture",
                        "Biotechnology",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Information & Communication Technology",
                        "Vocational Training",
                        "Women's Development & Empowerment"
                    }
                },
                new NGO
                {
                    Id = 9,
                    NGOName = "Centre for Advanced Research and Development",
                    RegistrationNumber = "25634",
                    NGOAddress = "Bhopal, MADHYA PRADESH, https://www.cardindia.org/, H-2/195, ARVIND VIHAR, BAGMUGALIA, BHOPAL",
                    WorkingSectors = new List<string>
                    {
                        "Any Other",
                        "Agriculture",
                        "Animal Husbandry, Dairying & Fisheries",
                        "Children",
                        "Drinking Water",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Food Processing",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Land Resources",
                        "Panchayati Raj",
                        "Rural Development & Poverty Alleviation",
                        "Science & Technology",
                        "Tribal Affairs",
                        "Vocational Training",
                        "Women's Development & Empowerment",
                        "Dalit Upliftment",
                        "Tourism",
                        "Water Resources",
                        "Skill Development"
                    }
                },
                new NGO
                {
                    Id = 10,
                    NGOName = "Srijan Mahila Vikas Manch",
                    RegistrationNumber = "363",
                    NGOAddress = "Chakradharpur, JHARKHAND, http://www.smvmngo.org, Nargis Manzil, Bangla Tand, Ward No 12 PO - Chakradharpur",
                    WorkingSectors = new List<string>
                    {
                        "Agriculture",
                        "Children",
                        "Differently Abled",
                        "Education & Literacy",
                        "Environment & Forests",
                        "Health & Family Welfare",
                        "HIV/AIDS",
                        "Micro Finance (SHGs)",
                        "Nutrition",
                        "Prisoner's Issues",
                        "Rural Development & Poverty Alleviation",
                        "Urban Development & Poverty Alleviation",
                        "Tribal Affairs",
                        "Vocational Training",
                        "Women's Development & Empowerment",
                        "Youth Affairs"
                    }
                }
            );
        }
    }
}
