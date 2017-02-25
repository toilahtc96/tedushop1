using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }
        [MaxLength(256)]
        public String URL { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public int GroupID { get; set; }
        [MaxLength(10)]
       
        public String Target { get; set; }
        public bool Status { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}
