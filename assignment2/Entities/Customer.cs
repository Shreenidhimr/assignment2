using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace assignment2.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [StringLength(5)]
        public string Cid { get; set; }   
        [StringLength(50)]
        [Required]
        public string Cname { get; set; }
        public string? EmailId { get; set; }
        [StringLength(13)]
        [Required]
        public string MobileNo { get; set; }
        public string? city { get; set; }
    }
}
