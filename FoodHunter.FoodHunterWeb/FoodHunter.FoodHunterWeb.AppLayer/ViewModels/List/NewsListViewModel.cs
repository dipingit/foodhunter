﻿using FoodHunter.FoodHunterWeb.AppLayer.ViewModels.Base;

namespace FoodHunter.Web.AppLayer.ViewModels.List
{
    public class NewsListViewModel : NewsBaseViewModel
    {
        public int NewsId { get; set; }
        public string RestaurantName { get; set; }
    }
}