﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sufrati.Data;

namespace Sufrati_backEnd.API.Migrations
{
    [DbContext(typeof(SufratiContext))]
    partial class SufratiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sufrati.Domain.Entities.Attachment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OriginalFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalFileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.AttachmentType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttachmentDescAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AttachmentDescEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxSize")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("AttachmentType");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.AttachmentTypeFileType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AttachmentTypeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileTypeID")
                        .HasColumnType("bigint");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AttachmentTypeID");

                    b.HasIndex("FileTypeID");

                    b.ToTable("AttachmentTypeFileType");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.AuditLog", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColumnName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InstanceIdValue")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NewValue")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OldValue")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UpdatedByID")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("AuditLog");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.FileType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("FileTypeDescAr")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FileTypeDescEn")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("FileType");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.GeneralLookupType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GeneralLookupNameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralLookupNameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GeneralLookupType");

                    b.HasData(
                        new
                        {
                            ID = 105000000000001L,
                            GeneralLookupNameAr = "نوع المستخدم",
                            GeneralLookupNameEn = "User Type"
                        });
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.GeneralLookupValue", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("GeneralLookupTypeID")
                        .HasColumnType("bigint");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ValueAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GeneralLookupTypeID");

                    b.ToTable("GeneralLookupValue");

                    b.HasData(
                        new
                        {
                            ID = 106000000000001L,
                            CreatedByID = 101000000000001L,
                            CreatedDate = new DateTime(2020, 9, 25, 18, 36, 9, 79, DateTimeKind.Local).AddTicks(8582),
                            GeneralLookupTypeID = 105000000000001L,
                            IPAddress = "127.0.0.1",
                            LastModifiedByID = 101000000000001L,
                            LastModifiedDate = new DateTime(2020, 9, 25, 18, 36, 9, 79, DateTimeKind.Local).AddTicks(8663),
                            ValueAr = "آدمن رئيسي",
                            ValueEn = "admin"
                        });
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.Groups", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionAr")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DescriptionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.HasIndex("NameAr")
                        .IsUnique();

                    b.HasIndex("NameEn")
                        .IsUnique();

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            ID = 147000000000001L,
                            CreatedByID = 101000000000001L,
                            CreatedDate = new DateTime(2020, 9, 25, 18, 36, 9, 82, DateTimeKind.Local).AddTicks(9286),
                            DescriptionAr = "هذه المجموعة للمسؤولين الرئيسين",
                            DescriptionEn = "this group for Admins",
                            IPAddress = "127.0.0.1",
                            LastModifiedByID = 101000000000001L,
                            LastModifiedDate = new DateTime(2020, 9, 25, 18, 36, 9, 82, DateTimeKind.Local).AddTicks(9357),
                            NameAr = "أدمن",
                            NameEn = "Admins"
                        });
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.MyNLog", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EntityID")
                        .HasColumnType("bigint");

                    b.Property<string>("ExceptionMessages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LogTypeID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LogoutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessagesCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PasswordChangedByID")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("LogTypeID");

                    b.HasIndex("PasswordChangedByID");

                    b.HasIndex("UserID");

                    b.ToTable("MyNLog");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.PasswordPolicy", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FirstLoginChangePassword")
                        .HasColumnType("bit");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IncludeCharacter")
                        .HasColumnType("bit");

                    b.Property<bool>("IncludeNumeric")
                        .HasColumnType("bit");

                    b.Property<bool>("IncludeSpecialCharacter")
                        .HasColumnType("bit");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MinLength")
                        .HasColumnType("int");

                    b.Property<int>("SessionAfterEnd")
                        .HasColumnType("int");

                    b.Property<int>("SuspendPasswordAfter")
                        .HasColumnType("int");

                    b.Property<string>("TitleAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TitleEn")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.HasKey("ID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.ToTable("PasswordPolicy");

                    b.HasData(
                        new
                        {
                            ID = 148000000000001L,
                            CreatedByID = 101000000000001L,
                            CreatedDate = new DateTime(2020, 9, 25, 18, 36, 9, 26, DateTimeKind.Local).AddTicks(7672),
                            FirstLoginChangePassword = true,
                            IPAddress = "127.0.0.1",
                            IncludeCharacter = true,
                            IncludeNumeric = true,
                            IncludeSpecialCharacter = true,
                            LastModifiedByID = 101000000000001L,
                            LastModifiedDate = new DateTime(2020, 9, 25, 18, 36, 9, 31, DateTimeKind.Local).AddTicks(8441),
                            MinLength = 6,
                            SessionAfterEnd = 60,
                            SuspendPasswordAfter = 5,
                            TitleAr = "سياسة 1",
                            TitleEn = "Policy 1"
                        });
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.SystemConstant", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttachmentPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EnableSSL")
                        .HasColumnType("bit");

                    b.Property<decimal>("FinesAmountPerEachDayDelayed")
                        .HasColumnType("decimal(10, 4)");

                    b.Property<string>("FormEmailAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxCompensationAmount")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<int>("NotifyBanksForInvoiceAfter")
                        .HasColumnType("int");

                    b.Property<string>("OutgoingSMTPServer")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("QualitativeCriteriaMaxScore")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("SMTPPortNumber")
                        .HasColumnType("int");

                    b.Property<bool>("SMTPServerRequiresAuthentication")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalQuantitativeCriteriaMaxScore")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Weekend")
                        .IsRequired()
                        .HasColumnType("char(7)");

                    b.HasKey("ID");

                    b.ToTable("SystemConstant");
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<long?>("AttachmentID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HomePhone")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("LastModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<long>("NumberOfWrongLogin")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("PasswordActive")
                        .HasColumnType("bit");

                    b.Property<long>("PasswordPolicyID")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserImageID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserTypeID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("AttachmentID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LoginName")
                        .IsUnique();

                    b.HasIndex("PasswordPolicyID");

                    b.HasIndex("UserTypeID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 101000000000001L,
                            Address = "Ramallah",
                            CreatedByID = 101000000000001L,
                            CreatedDate = new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3245),
                            Email = "Admin@Gmail.com",
                            HomePhone = "022965472",
                            IPAddress = "127.0.0.1",
                            IsActive = true,
                            LastModifiedByID = 101000000000001L,
                            LastModifiedDate = new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3330),
                            LoginName = "Admin",
                            Mobile = "0599999999",
                            NameAr = "مسؤول النظام",
                            NameEn = "Admin",
                            Notes = "Admin User of the system",
                            NumberOfWrongLogin = 0L,
                            Password = "YgMhEvQnlflEL8BH8bJdIw==:::9CwV4SYQmQhYNpHuA9RL6pKNWlocxWw428/dRClVpjE=",
                            PasswordActive = false,
                            PasswordPolicyID = 148000000000001L,
                            UserTypeID = 106000000000001L
                        },
                        new
                        {
                            ID = 101000000000002L,
                            Address = "Ramallah",
                            CreatedByID = 101000000000001L,
                            CreatedDate = new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3552),
                            Email = "Ala@Gmail.com",
                            HomePhone = "022965472",
                            IPAddress = "127.0.0.1",
                            IsActive = true,
                            LastModifiedByID = 101000000000001L,
                            LastModifiedDate = new DateTime(2020, 9, 25, 18, 36, 9, 72, DateTimeKind.Local).AddTicks(3565),
                            LoginName = "Ala",
                            Mobile = "0599999999",
                            NameAr = "علاء",
                            NameEn = "Ala",
                            Notes = "Admin User of the system",
                            NumberOfWrongLogin = 0L,
                            Password = "YgMhEvQnlflEL8BH8bJdIw==:::9CwV4SYQmQhYNpHuA9RL6pKNWlocxWw428/dRClVpjE=",
                            PasswordActive = false,
                            PasswordPolicyID = 148000000000001L,
                            UserTypeID = 106000000000001L
                        });
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.UserGroup", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.HasIndex("UserID");

                    b.HasIndex("ID", "GroupID", "UserID")
                        .IsUnique();

                    b.ToTable("UserGroup");

                    b.HasData(
                        new
                        {
                            ID = 152000000000001L,
                            GroupID = 147000000000001L,
                            UserID = 101000000000001L
                        });
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.AttachmentTypeFileType", b =>
                {
                    b.HasOne("Sufrati.Domain.Entities.AttachmentType", "AttachmentType")
                        .WithMany("FileTypes")
                        .HasForeignKey("AttachmentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sufrati.Domain.Entities.FileType", "FileType")
                        .WithMany()
                        .HasForeignKey("FileTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.GeneralLookupValue", b =>
                {
                    b.HasOne("Sufrati.Domain.Entities.GeneralLookupType", "GeneralLookupType")
                        .WithMany("GeneralLookupValues")
                        .HasForeignKey("GeneralLookupTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.MyNLog", b =>
                {
                    b.HasOne("Sufrati.Domain.Entities.GeneralLookupValue", "LogType")
                        .WithMany()
                        .HasForeignKey("LogTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sufrati.Domain.Entities.User", "PasswordChangedByUser")
                        .WithMany()
                        .HasForeignKey("PasswordChangedByID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Sufrati.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.User", b =>
                {
                    b.HasOne("Sufrati.Domain.Entities.Attachment", "Attachment")
                        .WithMany()
                        .HasForeignKey("AttachmentID");

                    b.HasOne("Sufrati.Domain.Entities.PasswordPolicy", "PasswordPolicy")
                        .WithMany("Users")
                        .HasForeignKey("PasswordPolicyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sufrati.Domain.Entities.GeneralLookupValue", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sufrati.Domain.Entities.UserGroup", b =>
                {
                    b.HasOne("Sufrati.Domain.Entities.Groups", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sufrati.Domain.Entities.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
