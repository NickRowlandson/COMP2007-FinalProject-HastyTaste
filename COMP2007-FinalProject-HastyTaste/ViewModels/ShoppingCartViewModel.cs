﻿using COMP2007_FinalProject_HastyTaste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_FinalProject_HastyTaste.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}