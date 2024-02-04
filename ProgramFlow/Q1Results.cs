using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public static class Q1Results
    {
        //Agrregate rating
        public static double ServiceScore { get; set; } = 8.0;
        public static double CoffeeScore { get; set; } = 8.5;
        public static double PriceScore { get; set; } = 6.0;
        public static double FoodScore { get; set; } = 7.5;
        public static double WouldRecommend { get; set; } = 7.5;
        public static string FavouriteProduct { get; set; } = "Cappuciono";
        public static string LeastFavourite { get; set; } = "Granola mix";

        //Agrregate counts
        public static double NumberSuryed { get; set; } = 500;
        public static double NumberResponded { get; set; } = 325;
        public static double NumberRewardsMembers { get; set; } = 130;


    }
}
