using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class AuditLog
    {
        [Key]
        public long ID { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string UpdatedByID { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string TableName { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string ColumnName { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string OldValue { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string NewValue { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string InstanceIdValue { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string IPAddress { get; set; }

    }
}
