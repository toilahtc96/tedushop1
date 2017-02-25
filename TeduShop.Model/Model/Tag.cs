using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
      
        public String ID { get; set; }
        [MaxLength(50)]
        [Required]
        public String Name { get; set; }
        [MaxLength(50)]
        [Required]
        public String Type { get; set; }

       
    }
}
