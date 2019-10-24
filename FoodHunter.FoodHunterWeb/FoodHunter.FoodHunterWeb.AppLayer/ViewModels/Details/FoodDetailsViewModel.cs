﻿using FoodHunter.FoodHunterWeb.AppLayer.ViewModels.Base;
using FoodHunter.Web.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodHunter.FoodHunterWeb.AppLayer.ViewModels.Create;

namespace FoodHunter.FoodHunterWeb.AppLayer.ViewModels.Details
{
    public class FoodDetailsViewModel : FoodBaseViewModel
    {
        public Restaurant Restaurant { get; set; }
        public List<Review> Reviews { get; set; }
        public ReviewCreateViewModel ReviewCreate { get; set; }
    }
}