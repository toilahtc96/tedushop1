using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("Pages")]
    public class Pages :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public String Name { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        
        public string Content { set; get; }
    }
}
