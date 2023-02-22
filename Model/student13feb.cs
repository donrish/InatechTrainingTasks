using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCONSOLE.Model
{
    public class student13feb
    {
        [Key]
        public int Studentid { get; set; }
        public string? StudentName { get; set; }
        [ForeignKey("Standard")] // simple name 
        public int Standardrefid { get; set; } //can give any name; ref for understading
        public Standard? Standard { get; set; }
    }
    public class Standard
    {
        [Key]
        public int Standardid { get; set; }
        public string? Standardname { get; set; }
        public ICollection<student13feb>? Students { get; set; } //for multiple student entries
    }
}