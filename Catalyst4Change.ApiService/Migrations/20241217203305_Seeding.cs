using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalyst4Change.ApiService.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NGOList",
                columns: new[] { "Id", "NGOAddress", "NGOName", "RegistrationNumber", "WorkingSectors" },
                values: new object[,]
                {
                    { 1, "BOLANGIR, ORISSA https://www.odishanews24.in, RUGUDIPARA NEAR TELEPHONE EXCHANGE OFFICE BALANGIR", "PRERANA", "6301-41", "[\"Agriculture\",\"Animal Husbandry, Dairying \\u0026 Fisheries\",\"Art \\u0026 Culture\",\"Children\",\"Differently Abled\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Aged/Elderly\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Human Rights\",\"Information \\u0026 Communication Technology\",\"Labour \\u0026 Employment\",\"Micro Small \\u0026 Medium Enterprises\",\"New \\u0026 Renewable Energy\",\"Panchayati Raj\",\"Scientific \\u0026 Industrial Research\",\"Water Resources\",\"Women\\u0027s Development \\u0026 Empowerment\"]" },
                    { 2, "Port Blair, ANDAMAN & NICOBAR ISLANDS http://arpan.ngo.tripod.com, ARPAN Enem Post Ograbraj", "ARPAN", "1316", "[\"Aged/Elderly\",\"Agriculture\",\"Art \\u0026 Culture\",\"Children\",\"Civic Issues\",\"Differently Abled\",\"Disaster Management\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Housing\",\"Human Rights\",\"Information \\u0026 Communication Technology\",\"Legal Awareness \\u0026 Aid\",\"Micro Finance (SHGs)\",\"Minority Issues\",\"Micro Small \\u0026 Medium Enterprises\",\"Nutrition\",\"Panchayati Raj\",\"Right to Information \\u0026 Advocacy\",\"Rural Development \\u0026 Poverty Alleviation\",\"Sports\"]" },
                    { 3, "Narela, DELHI, 65, Pana Udyan, Narela, Delhi - 110040", "Pragya Network Educational Society", "S-52559", "[\"Aged/Elderly\",\"Agriculture\",\"Art \\u0026 Culture\",\"Children\",\"Civic Issues\",\"Differently Abled\",\"Disaster Management\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Housing\",\"Micro Finance (SHGs)\",\"Nutrition\",\"Panchayati Raj\",\"Rural Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Urban Development \\u0026 Poverty Alleviation\",\"Vocational Training\",\"Water Resources\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Youth Affairs\",\"Minority Issues\",\"Food Processing\",\"Information \\u0026 Communication Technology\",\"Labour \\u0026 Employment\",\"New \\u0026 Renewable Energy\"]" },
                    { 4, "Aizawl, MIZORAM, N7-11, H Chhawntluanga Bldg, Durtlang Road, Bawngkawn, Aizawl-796 014 Mizoram", "Save Help and Develop S H A D E", "S.R. - 77/97/MZ-RFS of 1997", "[\"HIV/AIDS\",\"Tribal Affairs\"]" },
                    { 5, "Jaipur, RAJASTHAN, http://www.cecoedecon.org.in, F-159-160, Institutional", "Centre for Community Economics and Development Consultants Society", "206", "[\"Animal Husbandry, Dairying \\u0026 Fisheries\",\"Agriculture\",\"Disaster Management\",\"Drinking Water\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"Micro Finance (SHGs)\",\"Minority Issues\",\"Civic Issues\",\"Dalit Upliftment\",\"Education \\u0026 Literacy\",\"Human Rights\",\"Land Resources\",\"Legal Awareness \\u0026 Aid\",\"Nutrition\",\"Panchayati Raj\",\"Right to Information \\u0026 Advocacy\",\"Rural Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Urban Development \\u0026 Poverty Alleviation\",\"Vocational Training\",\"Water Resources\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Agriculture\"]" },
                    { 6, "TIRUCHULI, TAMIL NADU, http://www.odamindia.org, 197, WEST CAR STREET TIRUCHULI-626129", "ODAM", "43/1995", "[\"Aged/Elderly\",\"Agriculture\",\"Biotechnology\",\"Children\",\"Differently Abled\",\"Disaster Management\",\"Dalit Upliftment\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Housing\",\"Human Rights\",\"Micro Finance (SHGs)\",\"Minority Issues\",\"Micro Small \\u0026 Medium Enterprises\",\"New \\u0026 Renewable Energy\",\"Nutrition\",\"Scientific \\u0026 Industrial Research\",\"Science \\u0026 Technology\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Legal Awareness \\u0026 Aid\",\"Rural Development \\u0026 Poverty Alleviation\"]" },
                    { 7, "South Delhi, DELHI, http://haryali.org.in, Plot No. 14, 2nd Floor, Zakir Nagar West, New Delhi-110025", "HARYALI CENTRE FOR RURAL DEVELOPMENT", "S-29712", "[\"Aged/Elderly\",\"Agriculture\",\"Children\",\"Differently Abled\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Micro Finance (SHGs)\",\"Nutrition\",\"Panchayati Raj\",\"Rural Development \\u0026 Poverty Alleviation\",\"Urban Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\"]" },
                    { 8, "SUNDERNAGAR, HIMACHAL PRADESH, Pungh Sundernagar Distt. Mandi (HP)", "OPEN EDUCATIONAL DEVELOPMENT RESEARCH AND WELFARE", "126/2004", "[\"Art \\u0026 Culture\",\"Biotechnology\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Information \\u0026 Communication Technology\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\"]" },
                    { 9, "Bhopal, MADHYA PRADESH, https://www.cardindia.org/, H-2/195, ARVIND VIHAR, BAGMUGALIA, BHOPAL", "Centre for Advanced Research and Development", "25634", "[\"Any Other\",\"Agriculture\",\"Animal Husbandry, Dairying \\u0026 Fisheries\",\"Children\",\"Drinking Water\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Food Processing\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Land Resources\",\"Panchayati Raj\",\"Rural Development \\u0026 Poverty Alleviation\",\"Science \\u0026 Technology\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Dalit Upliftment\",\"Tourism\",\"Water Resources\",\"Skill Development\"]" },
                    { 10, "Chakradharpur, JHARKHAND, http://www.smvmngo.org, Nargis Manzil, Bangla Tand, Ward No 12 PO - Chakradharpur", "Srijan Mahila Vikas Manch", "363", "[\"Agriculture\",\"Children\",\"Differently Abled\",\"Education \\u0026 Literacy\",\"Environment \\u0026 Forests\",\"Health \\u0026 Family Welfare\",\"HIV/AIDS\",\"Micro Finance (SHGs)\",\"Nutrition\",\"Prisoner\\u0027s Issues\",\"Rural Development \\u0026 Poverty Alleviation\",\"Urban Development \\u0026 Poverty Alleviation\",\"Tribal Affairs\",\"Vocational Training\",\"Women\\u0027s Development \\u0026 Empowerment\",\"Youth Affairs\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NGOList",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
