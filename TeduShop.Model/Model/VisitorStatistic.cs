using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [key]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisiteDate { set; get; }
        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
