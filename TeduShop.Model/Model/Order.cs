using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerName{ get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerAddress { get; set; }

        [Required]
        [MaxLength(256)]
        public String CustomerEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public String CustomerMobile { get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerMessage { get; set; }
        public DateTime? CreateDate { get; set; }
        public String CreateBy { get; set; }
        public String PaymentMethod { get; set; }
        public String PaymentStatus { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
