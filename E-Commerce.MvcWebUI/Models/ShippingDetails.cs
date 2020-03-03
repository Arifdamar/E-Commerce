using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public string AddressTitle { get; set; }

        [Required(ErrorMessage = "Please enter the address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the district")]
        public string District { get; set; }

        [Required(ErrorMessage = "Please enter the street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter the zip code")]
        public string ZipCode { get; set; }


    }
}