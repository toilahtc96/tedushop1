using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("Slides")]
    public class Slide
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       
        [Required]
        [MaxLength(256)]
        public String Name { get; set; }
        [MaxLength(256)]
        public String Description { get; set; }
        
        [MaxLength(256)]
        public String Image { get; set; }
        
        [MaxLength(256)]
        public String URL { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
