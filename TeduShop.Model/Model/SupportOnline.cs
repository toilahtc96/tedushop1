using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public String Name {get;set;}
        [MaxLength(50)]
        public String Department {get;set;}
        [MaxLength(50)]
        public String Skype {get;set;}
        [MaxLength(50)]
        public String Mobile {get;set;}
        [MaxLength(50)]
        public String Email {get;set;}
        [MaxLength(50)]
        public String Facebook{get;set;}
        [MaxLength(50)]
        public String Yahoo{get;set;}
        public bool Status {get;set;}
        public int? DisplayOrder { get; set; }
}
}
