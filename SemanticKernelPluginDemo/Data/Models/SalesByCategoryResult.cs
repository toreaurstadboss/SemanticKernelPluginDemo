﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SemanticKernelPluginDemo.Models
{
    public partial class SalesByCategoryResult
    {
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("TotalPurchase", TypeName = "decimal(38,2)")]
        public decimal? TotalPurchase { get; set; }
    }
}
