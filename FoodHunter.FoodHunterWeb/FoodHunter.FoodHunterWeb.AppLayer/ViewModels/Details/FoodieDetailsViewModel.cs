﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FoodHunter.FoodHunterWeb.AppLayer.ViewModels.Base;
using FoodHunter.Web.DataLayer;

namespace FoodHunter.FoodHunterWeb.AppLayer.ViewModels.Details
{
    public class FoodieDetailsViewModel : FoodieBaseViewModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public CheckIn CheckIn { get; set; }
        public List<CheckIn> CheckIns { get; set; }
    }
}