using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sufrati_backEnd.API.Migrations
{
    public partial class _287 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "GeneralLookupType",
                columns: new[] { "ID", "GeneralLookupNameAr", "GeneralLookupNameEn" },
                values: new object[] { 105000000000003L, "تنصصيف حسب البلد", "Classification by Country" });

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
                columns: new[] { "AttachmentPath", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "C:\\SufratiAttachment", new DateTime(2020, 12, 28, 23, 5, 9, 165, DateTimeKind.Local).AddTicks(1835), new DateTime(2020, 12, 28, 23, 5, 9, 165, DateTimeKind.Local).AddTicks(1922) });

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

            migrationBuilder.InsertData(
                table: "GeneralLookupValue",
                columns: new[] { "ID", "CreatedByID", "CreatedDate", "GeneralLookupTypeID", "IPAddress", "LastModifiedByID", "LastModifiedDate", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 107000000000008L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8579), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8582), "فلسطيني", "Palestaine" },
                    { 107000000000009L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8586), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8589), "الجزائر", "Algeria" },
                    { 107000000000010L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8592), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8595), "سوريا", "Syrian" },
                    { 107000000000011L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8612), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8615), "تونس", "Tonsia" },
                    { 107000000000012L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8618), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8622), "اليمن", "Yaman" },
                    { 107000000000013L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8625), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8628), "السعودية", "Soudia" },
                    { 107000000000014L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8631), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8634), "لبنان", "Lebaone" },
                    { 107000000000015L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8638), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8641), "الاردن", "Jordan" },
                    { 107000000000016L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8644), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8647), "المغرب", "Morracow" },
                    { 107000000000018L, 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8651), 105000000000003L, "127.0.0.1", 101000000000001L, new DateTime(2020, 12, 28, 23, 5, 9, 143, DateTimeKind.Local).AddTicks(8654), "مصر", "Eygpt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000008L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000009L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000010L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000011L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000012L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000013L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000014L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000015L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000016L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000018L);

            migrationBuilder.DeleteData(
                table: "GeneralLookupType",
                keyColumn: "ID",
                keyValue: 105000000000003L);

            migrationBuilder.UpdateData(
                table: "Attachment",
                keyColumn: "ID",
                keyValue: 160000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 48, DateTimeKind.Local).AddTicks(2056), new DateTime(2020, 11, 13, 23, 28, 12, 48, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "AttachmentType",
                keyColumn: "ID",
                keyValue: 199000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 49, DateTimeKind.Local).AddTicks(1135), new DateTime(2020, 11, 13, 23, 28, 12, 49, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "AttachmentType",
                keyColumn: "ID",
                keyValue: 199000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 49, DateTimeKind.Local).AddTicks(1290), new DateTime(2020, 11, 13, 23, 28, 12, 49, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "AttachmentTypeFileType",
                keyColumn: "ID",
                keyValue: 110100000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 56, DateTimeKind.Local).AddTicks(9396), new DateTime(2020, 11, 13, 23, 28, 12, 56, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3282), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3414), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000003L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3439), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000004L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3463), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000005L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3488), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000006L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3511), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000007L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3531), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "FileType",
                keyColumn: "ID",
                keyValue: 198000000000008L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3543), new DateTime(2020, 11, 13, 23, 28, 12, 52, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 106000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9439), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9563), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000003L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9571), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000004L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9577), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000005L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9584), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000006L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9591), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "GeneralLookupValue",
                keyColumn: "ID",
                keyValue: 107000000000007L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9597), new DateTime(2020, 11, 13, 23, 28, 12, 33, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 147000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 35, DateTimeKind.Local).AddTicks(6373), new DateTime(2020, 11, 13, 23, 28, 12, 35, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "PasswordPolicy",
                keyColumn: "ID",
                keyValue: 148000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 9, DateTimeKind.Local).AddTicks(6999), new DateTime(2020, 11, 13, 23, 28, 12, 13, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "SystemConstant",
                keyColumn: "ID",
                keyValue: 107000000000001L,
                columns: new[] { "AttachmentPath", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "C:\\PCPSAttachement", new DateTime(2020, 11, 13, 23, 28, 12, 47, DateTimeKind.Local).AddTicks(5765), new DateTime(2020, 11, 13, 23, 28, 12, 47, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 101000000000001L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 29, DateTimeKind.Local).AddTicks(542), new DateTime(2020, 11, 13, 23, 28, 12, 29, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 101000000000002L,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 11, 13, 23, 28, 12, 29, DateTimeKind.Local).AddTicks(883), new DateTime(2020, 11, 13, 23, 28, 12, 29, DateTimeKind.Local).AddTicks(889) });
        }
    }
}
