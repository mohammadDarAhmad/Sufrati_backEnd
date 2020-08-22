using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Sufrati.Data.Configurations
{

    public class UserConfiguration
    {

        /// <summary>
        /// Here is some Tips
        /// entity.Property(t => t.OrderDate).HasDefaultValueSql("GetDate()");
        /// entity.HasKey(0 => o.OrderNumber);
        /// entity.Property(t => t.Email).ValueGeneratedOnAdd();  :property should never be generated automtically by the database.
        /// entity.HasAlternateKey(a => a.PassportNumber);
        /// entity.Propery(p => p.LastModified).HasComputedColumnSql("GetUtcDate()");
        /// entity.HasMany(c => c.Employees).WithOne(e => e.Company).HasConstraintName("MyFKConstraint");
        /// entity.HasData(
        ///     new Author
        ///     {
        ///         AuthorId = 1,
        ///         FirstName = "William",
        ///         LastName = "Shakespeare"
        ///     }
        /// entity.Propery(p => p.IsActive).HasDefaultValue(true);
        /// entity.Propery(p => p.DateCreated).HasDefaultValueSql("GetUtcDate()");
        /// entity.HasOne(b => b.Author).WithMany(a => a.Books).OnDelete(DeleteBehavior.SetNull);
        /// 
        /// more info > https://www.learnentityframeworkcore.com/configuration/fluent-api/property-configuration
        /// </summary>
        /// <param name="entity"></param>
        public UserConfiguration(EntityTypeBuilder<User> entity)
        {
            entity.HasIndex(e => e.LoginName).IsUnique();
            entity.HasIndex(e => e.Email).IsUnique();
            entity.HasOne(e => e.UserType);
            entity.HasOne(e => e.PasswordPolicy).WithMany(e => e.Users).HasForeignKey(e => e.PasswordPolicyID);
            entity.HasMany(e => e.UserGroups);

            entity.HasData(
                new User()
                {
                    ID = 101000000000001,
                    LoginName = "Ali",
                    Password = "536re62er6r",
                    NameAr = "علي",
                    NameEn = "Ali P",
                    UserTypeID = 106000000000001,
                    Email = "Ali@Gmail.com",
                    HomePhone = "",
                    Mobile = "",
                    Address = "",
                    Notes = "",
                    IsActive = true,
                    PasswordPolicyID = 148000000000001,
                    UserImageOriginal = "localhost://",
                    UserImageSmall = "localhost://",
                    CreatedByID = null,
                    Created_Date = DateTime.Now,
                    LastModifiedByID = null,
                    LastModifiedDate = DateTime.Now,
                    IPAddress = "127.0.0.1"
                },
                  new User()
                  {
                      ID = 101000000000002,
                      LoginName = "Ahmad",
                      Password = "536re62er6r",
                      NameAr = "احمد",
                      NameEn = "Ahmad P",
                      UserTypeID = 106000000000001,
                      Email = "Ahmad@Gmail.com",
                      HomePhone = "",
                      Mobile = "",
                      Address = "",
                      Notes = "",
                      IsActive = true,
                      PasswordPolicyID = 148000000000001,
                      UserImageOriginal = "localshost://",
                      UserImageSmall = "localhost://",
                      CreatedByID = 1,
                      Created_Date = DateTime.Now,
                      LastModifiedByID = 1,
                      LastModifiedDate = DateTime.Now,
                      IPAddress = "127.0.0.1"
                  }
                );


        }
    }
}
