using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApp.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="datetime2(7)")]
        public DateTime Date { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Trade_Code { get; set; }

        [Column(TypeName = "float")]
        public float High { get; set; }

        [Column(TypeName = "float")]
        public float Low { get; set; }

        [Column(TypeName = "float")]
        public float Open { get; set; }

        [Column(TypeName = "float")]
        public float Close { get; set; }

        [Column(TypeName = "float")]
        public float Volume { get; set; }

        
    }
}
