using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2_n01549081.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// J1 - Calculating calories of the meal
        /// </summary>
        /// <param name="burger">Burger choice</param>
        /// <param name="drink">Drink choice</param>
        /// <param name="side">Side choice</param>
        /// <param name="dessert">Dessert choice</param>
        /// <returns>Total calorie count of meal</returns>
        /// <example>
        /// GET api/J1/menu/4/4/4/4 -> 0
        /// GET api/J1/menu/1/2/3/4 -> 691
        /// </example>
        [Route("api/J1/menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string CalorieCalulator(int burger, int drink, int side, int dessert)
        {
            int calories = 0;
            if (burger == 1)
            {
                calories += 461;
            }
            else if (burger == 2)
            {
                calories += 431;
            }
            else if (burger == 3)
            {
                calories += 420;
            }
            else if(burger == 4)
            {
                calories += 0;
            }

            if (drink == 1)
            {
                calories += 130;
            }
            else if (drink == 2)
            {
                calories += 160;
            }
            else if (drink == 3)
            {
                calories += 118;
            }
            else if (drink == 4)
            {
                calories += 0;
            }

            if (side == 1)
            {
                calories += 100;
            }
            else if (side == 2)
            {
                calories += 57;
            }
            else if (side == 3)
            {
                calories += 70;
            }
            else if (side == 4)
            {
                calories += 0;
            }

            if (dessert == 1)
            {
                calories += 167;
            }
            else if (dessert == 2)
            {
                calories += 266;
            }
            else if (dessert == 3)
            {
                calories += 75;
            }
            else if (dessert == 4)
            {
                calories += 0;
            }
            return "Your total calorie count is " + calories;
        }
    }
}
