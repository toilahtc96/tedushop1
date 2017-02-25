using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("ProductTags")]
    public   class ProductTags
    {
        [key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public int TagID { get; set; }
        [Key]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
     }
}
