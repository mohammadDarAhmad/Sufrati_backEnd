using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class PasswordPolicyConfiguration
    {
        public PasswordPolicyConfiguration(EntityTypeBuilder<PasswordPolicy> entity)
        {
            entity.HasIndex(e => new { e.ID }).IsUnique();
            entity.HasData(
                new PasswordPolicy()
                {
                    ID = 148000000000001,
                    TitleAr = "سياسة 1",
                    TitleEn = "Policy 1",
                    FirstLoginChangePassword = true,
                    IncludeCharacter = true,
                    IncludeNumeric = true,
                    IncludeSpecialCharacter = true,
                    MinLength = 6,
                    SessionAfterEnd = 60,
                    SuspendPasswordAfter = 5,
                    CreatedByID = 101000000000001,
                    Created_Date = DateTime.Now,
                    LastModifiedByID = 101000000000001,
                    LastModifiedDate = DateTime.Now,
                    IPAddress = "127.0.0.1"
                });
        }
    }
}
