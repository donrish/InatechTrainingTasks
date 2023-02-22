using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCONSOLE.Model
{
    internal class prodbatch
    {
        [Key]
        public int batchId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
        [ForeignKey("Productfk")]
        public product Product { get; set; }  

    }
}
