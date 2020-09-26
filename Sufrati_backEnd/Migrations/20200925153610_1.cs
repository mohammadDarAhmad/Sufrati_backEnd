using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sufrati_backEnd.API.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    OriginalFileName = table.Column<string>(nullable: true),
                    PhysicalFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentType",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    AttachmentDescAr = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AttachmentDescEn = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MaxSize = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentType", x => x.ID);
                });

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
                name: "FileType",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    FileExtension = table.Column<string>(type: "varchar(5)", nullable: false),
                    FileTypeDescAr = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    FileTypeDescEn = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.ID);
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    FirstLoginChangePassword = table.Column<bool>(nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    TitleEn = table.Column<string>(type: "varchar(1000)", nullable: false),
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
                name: "SystemConstant",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    NotifyBanksForInvoiceAfter = table.Column<int>(nullable: false),
                    MaxCompensationAmount = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    TotalQuantitativeCriteriaMaxScore = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    QualitativeCriteriaMaxScore = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    FinesAmountPerEachDayDelayed = table.Column<decimal>(type: "decimal(10, 4)", nullable: false),
                    OutgoingSMTPServer = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SMTPServerRequiresAuthentication = table.Column<bool>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FormEmailAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    EnableSSL = table.Column<bool>(nullable: false),
                    SMTPPortNumber = table.Column<int>(nullable: false),
                    Weekend = table.Column<string>(type: "char(7)", nullable: false),
                    AttachmentPath = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConstant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentTypeFileType",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    AttachmentTypeID = table.Column<long>(nullable: false),
                    FileTypeID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentTypeFileType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AttachmentTypeFileType_AttachmentType_AttachmentTypeID",
                        column: x => x.AttachmentTypeID,
                        principalTable: "AttachmentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttachmentTypeFileType_FileType_FileTypeID",
                        column: x => x.FileTypeID,
                        principalTable: "FileType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLookupValue",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByID = table.Column<long>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    LoginName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "varchar(200)", nullable: false),
                    UserTypeID = table.Column<long>(nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    HomePhone = table.Column<string>(type: "varchar(100)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address = table.Column<string>(maxLength: 1000, nullable: true),
                    Notes = table.Column<string>(type: "ntext", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PasswordActive = table.Column<bool>(nullable: false),
                    PasswordPolicyID = table.Column<long>(nullable: false),
                    UserImageID = table.Column<long>(nullable: true),
                    NumberOfWrongLogin = table.Column<long>(nullable: false),
                    AttachmentID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Attachment_AttachmentID",
                        column: x => x.AttachmentID,
                        principalTable: "Attachment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "MyNLog",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(type: "varchar(15)", nullable: false),
                    UserID = table.Column<long>(nullable: true),
                    RequestURL = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    EntityID = table.Column<long>(nullable: true),
                    LogTypeID = table.Column<long>(nullable: false),
                    ExceptionType = table.Column<string>(nullable: true),
                    ExceptionMessages = table.Column<string>(nullable: true),
                    MessagesCode = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    PasswordChangedByID = table.Column<long>(nullable: true),
                    LogoutTime = table.Column<DateTime>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyNLog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MyNLog_GeneralLookupValue_LogTypeID",
                        column: x => x.LogTypeID,
                        principalTable: "GeneralLookupValue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyNLog_User_PasswordChangedByID",
                        column: x => x.PasswordChangedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MyNLog_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
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
                columns: new[] { "ID", "CreatedByID", "CreatedDate", "DescriptionAr", "DescriptionEn", "IPAddress", "LastModifiedByID", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[] { 147000000000001L, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 82, DateTimeKind.Local).AddTicks(9286), "هذه المجموعة للمسؤولين الرئيسين", "this group for Admins", "127.0.0.1", 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 82, DateTimeKind.Local).AddTicks(9357), "أدمن", "Admins" });

            migrationBuilder.InsertData(
                table: "PasswordPolicy",
                columns: new[] { "ID", "CreatedByID", "CreatedDate", "FirstLoginChangePassword", "IPAddress", "IncludeCharacter", "IncludeNumeric", "IncludeSpecialCharacter", "LastModifiedByID", "LastModifiedDate", "MinLength", "SessionAfterEnd", "SuspendPasswordAfter", "TitleAr", "TitleEn" },
                values: new object[] { 148000000000001L, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 26, DateTimeKind.Local).AddTicks(7672), true, "127.0.0.1", true, true, true, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 31, DateTimeKind.Local).AddTicks(8441), 6, 60, 5, "سياسة 1", "Policy 1" });

            migrationBuilder.InsertData(
                table: "GeneralLookupValue",
                columns: new[] { "ID", "CreatedByID", "CreatedDate", "GeneralLookupTypeID", "IPAddress", "LastModifiedByID", "LastModifiedDate", "ValueAr", "ValueEn" },
                values: new object[] { 106000000000001L, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 79, DateTimeKind.Local).AddTicks(8582), 105000000000001L, "127.0.0.1", 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 79, DateTimeKind.Local).AddTicks(8663), "آدمن رئيسي", "admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "AttachmentID", "CreatedByID", "CreatedDate", "Email", "HomePhone", "IPAddress", "IsActive", "LastModifiedByID", "LastModifiedDate", "LoginName", "Mobile", "NameAr", "NameEn", "Notes", "NumberOfWrongLogin", "Password", "PasswordActive", "PasswordPolicyID", "UserImageID", "UserTypeID" },
                values: new object[] { 101000000000001L, "Ramallah", null, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3245), "Admin@Gmail.com", "022965472", "127.0.0.1", true, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3330), "Admin", "0599999999", "مسؤول النظام", "Admin", "Admin User of the system", 0L, "YgMhEvQnlflEL8BH8bJdIw==:::9CwV4SYQmQhYNpHuA9RL6pKNWlocxWw428/dRClVpjE=", false, 148000000000001L, null, 106000000000001L });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "AttachmentID", "CreatedByID", "CreatedDate", "Email", "HomePhone", "IPAddress", "IsActive", "LastModifiedByID", "LastModifiedDate", "LoginName", "Mobile", "NameAr", "NameEn", "Notes", "NumberOfWrongLogin", "Password", "PasswordActive", "PasswordPolicyID", "UserImageID", "UserTypeID" },
                values: new object[] { 101000000000002L, "Ramallah", null, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3552), "Ala@Gmail.com", "022965472", "127.0.0.1", true, 101000000000001L, new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3565), "Ala", "0599999999", "علاء", "Ala", "Admin User of the system", 0L, "YgMhEvQnlflEL8BH8bJdIw==:::9CwV4SYQmQhYNpHuA9RL6pKNWlocxWw428/dRClVpjE=", false, 148000000000001L, null, 106000000000001L });

            migrationBuilder.InsertData(
                table: "UserGroup",
                columns: new[] { "ID", "GroupID", "UserID" },
                values: new object[] { 152000000000001L, 147000000000001L, 101000000000001L });

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentTypeFileType_AttachmentTypeID",
                table: "AttachmentTypeFileType",
                column: "AttachmentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentTypeFileType_FileTypeID",
                table: "AttachmentTypeFileType",
                column: "FileTypeID");

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
                name: "IX_Groups_NameAr",
                table: "Groups",
                column: "NameAr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_NameEn",
                table: "Groups",
                column: "NameEn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyNLog_LogTypeID",
                table: "MyNLog",
                column: "LogTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MyNLog_PasswordChangedByID",
                table: "MyNLog",
                column: "PasswordChangedByID");

            migrationBuilder.CreateIndex(
                name: "IX_MyNLog_UserID",
                table: "MyNLog",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordPolicy_ID",
                table: "PasswordPolicy",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_AttachmentID",
                table: "User",
                column: "AttachmentID");

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
                name: "AttachmentTypeFileType");

            migrationBuilder.DropTable(
                name: "AuditLog");

            migrationBuilder.DropTable(
                name: "MyNLog");

            migrationBuilder.DropTable(
                name: "SystemConstant");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "AttachmentType");

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "PasswordPolicy");

            migrationBuilder.DropTable(
                name: "GeneralLookupValue");

            migrationBuilder.DropTable(
                name: "GeneralLookupType");
        }
    }
}
