using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
 


    /// <summary>
    /// Entity Framework Core Data Annotations
    ///  
    /// [Key]
    /// [ConcurrencyCheck] : You can use the ConcurrencyCheck attribute to configure a property as a concurrency token.
    /// [NotMapped] : You can use a NotMapped attribute to exclude a type from the model or any property of the entity.
    /// [Required]
    /// [MaxLength(50)]
    /// [MinLength(3)]
    /// [StringLength(50)]
    /// [ForeignKey("OrderID")]
    /// [Timestamp] :You can use the Timestamp attribute the same as ConcurrencyCheck attribute, but it will also ensure that the database field that code first generates is non-nullable.
    /// [Table("UserInfo")] : You can use Table attribute to map the class name which is different from the table name in the database.
    /// [Column("LName")] : You can use Column attribute to map the property name which is different from the column name in the database.
    /// [Column(TypeName ="varchar(100)")]
    /// </summary>


    public class User : BaseEntity
    {

        [Required]
        [MaxLength(100)]
        public string LoginName { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonIgnore]
        public string Password { get; set; }

        [Required]
        [MaxLength(200)]
        public string NameAr { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string NameEn { get; set; }

        [ForeignKey("GeneralLookupValueID")]
        [Required]
        public long UserTypeID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string HomePhone { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Mobile { get; set; }

        [MaxLength(1000)]
        public string Address { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public bool PasswordActive { get; set; }

        [Required]
        [ForeignKey("PasswordPolicyID")]
        public long PasswordPolicyID { get; set; }

        public long? UserImageID { get; set; }
        public long NumberOfWrongLogin { get; set; }


        public virtual GeneralLookupValue UserType { get; set; }
        public virtual PasswordPolicy PasswordPolicy { get; set; }
        public virtual List<UserGroup> UserGroups { get; set; }
        public virtual Attachment Attachment { get; set; }


    }
}
