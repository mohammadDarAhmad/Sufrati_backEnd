﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sufrati.Domain.Entities
{
    public class Bank
    {
        [Key]
        public int BankID { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string BankName { get; set; }
    }
}
