﻿namespace CoreAndFood.Data.Models.Dto
{
    public class FoodIViewDto:IDto
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public int Stock { get; set; }
        public string CategoryNameView { get; set; }


    }
}
