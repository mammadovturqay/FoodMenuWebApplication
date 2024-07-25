using System.Collections.Generic;
using WebAspTask1.Entities;

namespace WebAspTask1.Models
{
    public class FoodCategoriesViewModel
    {
        public List<FastFoods> FastFoods { get; set; }
        public List<HotMeals> HotMeals { get; set; }
        public List<Drinks> Drinks { get; set; }
    }
}
