using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sufrati_backEnd.API.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLog",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedByID = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ColumnName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    OldValue = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NewValue = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    InstanceIdValue = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLookupType",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralLookupNameAr = table.Column<string>(nullable: false),
                    GeneralLookupNameEn = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralLookupType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    NameAr = table.Column<string>(nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DescriptionEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PasswordPolicy",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    FirstLoginChangePassword = table.Column<bool>(nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    MinLength = table.Column<int>(nullable: false),
                    SessionAfterEnd = table.Column<int>(nullable: false),
                    SuspendPasswordAfter = table.Column<int>(nullable: false),
                    IncludeSpecialCharacter = table.Column<bool>(nullable: false),
                    IncludeNumeric = table.Column<bool>(nullable: false),
                    IncludeCharacter = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordPolicy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLookupValue",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    GeneralLookupTypeID = table.Column<long>(nullable: false),
                    ValueAr = table.Column<string>(nullable: false),
                    ValueEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralLookupValue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GeneralLookupValue_GeneralLookupType_GeneralLookupTypeID",
                        column: x => x.GeneralLookupTypeID,
                        principalTable: "GeneralLookupType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    Created_Date = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    LoginName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(maxLength: 200, nullable: false),
                    UserTypeID = table.Column<long>(nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    HomePhone = table.Column<string>(type: "varchar(100)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address = table.Column<string>(maxLength: 1000, nullable: true),
                    Notes = table.Column<string>(type: "ntext", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PasswordPolicyID = table.Column<long>(nullable: false),
                    UserImageOriginal = table.Column<string>(nullable: true),
                    UserImageSmall = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_PasswordPolicy_PasswordPolicyID",
                        column: x => x.PasswordPolicyID,
                        principalTable: "PasswordPolicy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_GeneralLookupValue_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "GeneralLookupValue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(nullable: false),
                    GroupID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserGroup_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroup_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GeneralLookupType",
                columns: new[] { "ID", "GeneralLookupNameAr", "GeneralLookupNameEn" },
                values: new object[] { 105000000000001L, "نوع المستخدم", "User Type" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "ID", "CreatedByID", "Created_Date", "DescriptionAr", "DescriptionEn", "IPAddress", "LastModifiedByID", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 147000000000001L, 101000000000001L, new DateTime(2020, 8, 22, 19, 9, 47, 612, DateTimeKind.Local).AddTicks(2307), "هذه المجموعة للمسؤولين الرئيسين", "this group for Admins", "127.0.0.1", 101000000000001L, new DateTime(2020, 8, 22, 19, 9, 47, 612, DateTimeKind.Local).AddTicks(2334), "أدمن", "Admins" });

            migrationBuilder.InsertData(
                table: "PasswordPolicy",
                columns: new[] { "ID", "CreatedByID", "Created_Date", "FirstLoginChangePassword", "IPAddress", "IncludeCharacter", "IncludeNumeric", "IncludeSpecialCharacter", "LastModifiedByID", "LastModifiedDate", "MinLength", "SessionAfterEnd", "SuspendPasswordAfter", "TitleAr", "TitleEn" },
                values: new object[] { 148000000000001L, 101000000000001L, new DateTime(2020, 8, 22, 19, 9, 47, 593, DateTimeKind.Local).AddTicks(7723), true, "127.0.0.1", true, true, true, 101000000000001L, new DateTime(2020, 8, 22, 19, 9, 47, 596, DateTimeKind.Local).AddTicks(7186), 6, 60, 5, "سياسة 1", "Policy 1" });

            migrationBuilder.InsertData(
                table: "GeneralLookupValue",
                columns: new[] { "ID", "CreatedByID", "Created_Date", "GeneralLookupTypeID", "IPAddress", "LastModifiedByID", "LastModifiedDate", "ValueAr", "ValueEn" },
                values: new object[] { 106000000000001L, 101000000000001L, new DateTime(2020, 8, 22, 19, 9, 47, 611, DateTimeKind.Local).AddTicks(1830), 105000000000001L, "127.0.0.1", 101000000000001L, new DateTime(2020, 8, 22, 19, 9, 47, 611, DateTimeKind.Local).AddTicks(1888), "آدمن رئيسي", "admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedByID", "Created_Date", "Email", "HomePhone", "IPAddress", "IsActive", "LastModifiedByID", "LastModifiedDate", "LoginName", "Mobile", "NameAr", "NameEn", "Notes", "Password", "PasswordPolicyID", "UserImageOriginal", "UserImageSmall", "UserTypeID" },
                values: new object[] { 101000000000001L, "", null, new DateTime(2020, 8, 22, 19, 9, 47, 607, DateTimeKind.Local).AddTicks(6541), "Ali@Gmail.com", "", "127.0.0.1", true, null, new DateTime(2020, 8, 22, 19, 9, 47, 607, DateTimeKind.Local).AddTicks(6598), "Ali", "", "علي", "Ali P", "", "536re62er6r", 148000000000001L, "localhost://", "localhost://", 106000000000001L });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedByID", "Created_Date", "Email", "HomePhone", "IPAddress", "IsActive", "LastModifiedByID", "LastModifiedDate", "LoginName", "Mobile", "NameAr", "NameEn", "Notes", "Password", "PasswordPolicyID", "UserImageOriginal", "UserImageSmall", "UserTypeID" },
                values: new object[] { 101000000000002L, "", 1L, new DateTime(2020, 8, 22, 19, 9, 47, 607, DateTimeKind.Local).AddTicks(6734), "Ahmad@Gmail.com", "", "127.0.0.1", true, 1L, new DateTime(2020, 8, 22, 19, 9, 47, 607, DateTimeKind.Local).AddTicks(6738), "Ahmad", "", "احمد", "Ahmad P", "", "536re62er6r", 148000000000001L, "localshost://", "localhost://", 106000000000001L });

            migrationBuilder.InsertData(
                table: "UserGroup",
                columns: new[] { "ID", "GroupID", "UserID" },
                values: new object[] { 152000000000001L, 147000000000001L, 101000000000001L });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLookupValue_GeneralLookupTypeID",
                table: "GeneralLookupValue",
                column: "GeneralLookupTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ID",
                table: "Groups",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PasswordPolicy_ID",
                table: "PasswordPolicy",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_LoginName",
                table: "User",
                column: "LoginName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_PasswordPolicyID",
                table: "User",
                column: "PasswordPolicyID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeID",
                table: "User",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_GroupID",
                table: "UserGroup",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_UserID",
                table: "UserGroup",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_ID_GroupID_UserID",
                table: "UserGroup",
                columns: new[] { "ID", "GroupID", "UserID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLog");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PasswordPolicy");

            migrationBuilder.DropTable(
                name: "GeneralLookupValue");

            migrationBuilder.DropTable(
                name: "GeneralLookupType");
        }
    }
}
