using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sufrati_backEnd.API.Migrations
{
    public partial class _444 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassificationSufrati",
                table: "Recipe",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "ID",
                keyValue: 160000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 669, DateTimeKind.Local).AddTicks(6398), new DateTime(2021, 1, 2, 13, 32, 54, 669, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "AttachmentType",
                keyColumn: "ID",
                keyValue: 199000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 671, DateTimeKind.Local).AddTicks(3713), new DateTime(2021, 1, 2, 13, 32, 54, 671, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "AttachmentType",
                keyColumn: "ID",
                keyValue: 199000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 671, DateTimeKind.Local).AddTicks(3938), new DateTime(2021, 1, 2, 13, 32, 54, 671, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "AttachmentTypeFileType",
                keyColumn: "ID",
                keyValue: 110100000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 704, DateTimeKind.Local).AddTicks(8888), new DateTime(2021, 1, 2, 13, 32, 54, 704, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2240), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2379), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000003L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2391), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000004L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2400), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000005L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2513), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000006L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2525), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000007L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2535), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000008L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2547), new DateTime(2021, 1, 2, 13, 32, 54, 676, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupType",
                keyColumn: "ID",
                keyValue: 105000000000002L,
                column: "GeneralLookupNameAr",
                value: "تصنيف حسب الاصناف");

            migrationBuilder.UpdateData(
                table: "GeneralLookupType",
                keyColumn: "ID",
                keyValue: 105000000000003L,
                column: "GeneralLookupNameAr",
                value: "تصنيف حسب البلد");

            migrationBuilder.InsertData(
                table: "GeneralLookupType",
                columns: new[] { "ID", "GeneralLookupNameAr", "GeneralLookupNameEn" },
                values: new object[] { 105000000000004L, "تصنيف سفرتي", "Classification by Sufrati Website" });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 106000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(373), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(573), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000003L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000004L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(625), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000005L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(655), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000006L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(685), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000007L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(716), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000008L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(746), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000009L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(775), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000010L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(787), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000011L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(799), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000012L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(812), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000013L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(824), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000014L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(835), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000015L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(861), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000016L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(888), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000018L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(899), new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 147000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 602, DateTimeKind.Local).AddTicks(3038), new DateTime(2021, 1, 2, 13, 32, 54, 602, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "PasswordPolicy",
                keyColumn: "ID",
                keyValue: 148000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 529, DateTimeKind.Local).AddTicks(2633), new DateTime(2021, 1, 2, 13, 32, 54, 534, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "SystemConstant",
                keyColumn: "ID",
                keyValue: 107000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 667, DateTimeKind.Local).AddTicks(8428), new DateTime(2021, 1, 2, 13, 32, 54, 667, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 101000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 585, DateTimeKind.Local).AddTicks(2102), new DateTime(2021, 1, 2, 13, 32, 54, 585, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 101000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2021, 1, 2, 13, 32, 54, 585, DateTimeKind.Local).AddTicks(2430), new DateTime(2021, 1, 2, 13, 32, 54, 585, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.InsertData(
                table: "GeneralLookupValue",
                columns: new[] { "ID", "CreatedByID", "CreatedDate", "GeneralLookupTypeID", "IPAddress", "LastModifiedByID", "LastModifiedDate", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 107000000000019L, 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(911), 105000000000004L, "127.0.0.1", 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(916), "لبنيات", "Laben" },
                    { 107000000000020L, 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(923), 105000000000004L, "127.0.0.1", 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(928), "ارزيات", "Raise" },
                    { 107000000000021L, 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(938), 105000000000004L, "127.0.0.1", 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(953), "يخنيات", "yaken" },
                    { 107000000000022L, 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(968), 105000000000004L, "127.0.0.1", 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(976), "قبب", "kbb" },
                    { 107000000000023L, 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(984), 105000000000004L, "127.0.0.1", 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(990), "ورقيات", "workss" },
                    { 107000000000024L, 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(997), 105000000000004L, "127.0.0.1", 101000000000001L, new DateTime(2021, 1, 2, 13, 32, 54, 598, DateTimeKind.Local).AddTicks(1003), "عدسيات", "3ds" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000019L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000020L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000021L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000022L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000023L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000024L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupType",
                keyColumn: "ID",
                keyValue: 105000000000004L);

            migrationBuilder.DropColumn(
                name: "ClassificationSufrati",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "ID",
                keyValue: 160000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 165, DateTimeKind.Local).AddTicks(9733), new DateTime(2020, 12, 28, 23, 5, 9, 165, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "AttachmentType",
                keyColumn: "ID",
                keyValue: 199000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 166, DateTimeKind.Local).AddTicks(8853), new DateTime(2020, 12, 28, 23, 5, 9, 166, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "AttachmentType",
                keyColumn: "ID",
                keyValue: 199000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 166, DateTimeKind.Local).AddTicks(9003), new DateTime(2020, 12, 28, 23, 5, 9, 166, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "AttachmentTypeFileType",
                keyColumn: "ID",
                keyValue: 110100000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 178, DateTimeKind.Local).AddTicks(412), new DateTime(2020, 12, 28, 23, 5, 9, 178, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8621), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8771), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000003L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8802), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000004L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8830), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000005L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8840), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000006L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8850), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000007L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8860), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000008L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8871), new DateTime(2020, 12, 28, 23, 5, 9, 171, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupType",
                keyColumn: "ID",
                keyValue: 105000000000002L,
                column: "GeneralLookupNameAr",
                value: "تنصصيف حسب الاصناف");

            migrationBuilder.UpdateData(
                table: "GeneralLookupType",
                keyColumn: "ID",
                keyValue: 105000000000003L,
                column: "GeneralLookupNameAr",
                value: "تنصصيف حسب البلد");

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 106000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8403), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8538), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000003L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8546), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000004L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8553), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000005L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8560), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000006L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8566), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000007L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8573), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000008L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8579), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000009L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8586), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000010L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8592), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000011L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8612), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000012L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8618), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000013L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8625), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000014L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8631), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000015L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8638), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000016L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8644), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000018L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8651), new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 147000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 146, DateTimeKind.Local).AddTicks(5598), new DateTime(2020, 12, 28, 23, 5, 9, 146, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "PasswordPolicy",
                keyColumn: "ID",
                keyValue: 148000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 119, DateTimeKind.Local).AddTicks(6500), new DateTime(2020, 12, 28, 23, 5, 9, 123, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "SystemConstant",
                keyColumn: "ID",
                keyValue: 107000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 165, DateTimeKind.Local).AddTicks(1835), new DateTime(2020, 12, 28, 23, 5, 9, 165, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 101000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 137, DateTimeKind.Local).AddTicks(9830), new DateTime(2020, 12, 28, 23, 5, 9, 137, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 101000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 12, 28, 23, 5, 9, 138, DateTimeKind.Local).AddTicks(45), new DateTime(2020, 12, 28, 23, 5, 9, 138, DateTimeKind.Local).AddTicks(49) });
        }
    }
}
