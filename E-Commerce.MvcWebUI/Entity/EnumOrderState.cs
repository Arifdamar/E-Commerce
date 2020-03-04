using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Entity
{
    public enum EnumOrderState
    {
        [Display(Name ="Waiting for confirmation")]
        Waiting,

        [Display(Name = "On the way")]
        EnRoute,

        [Display(Name = "Order Completed")]
        Completed
    }
}