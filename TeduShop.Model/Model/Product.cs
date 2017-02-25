﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("Products")]
    public class Product :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        public XElement MoreImage { get; set; }
        [Required]
        public string Image { set; get; }
     
       public Decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        [MaxLength(500)]
        public String Description { get; set; }
        public String Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
        
        
    }
}
