using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [StringLength(maximumLength:20,ErrorMessage ="Name must be shorter(max 20 character)")]
        public string Name { get; set; }
        [DisplayName("Category Description")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}