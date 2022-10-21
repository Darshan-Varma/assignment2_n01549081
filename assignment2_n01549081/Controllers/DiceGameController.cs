using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2_n01549081.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// J2 - Calculating number of ways to get sum of 10 by rolling two dice
        /// </summary>
        /// <param name="m">Sides of first dice</param>
        /// <param name="n">Sides of second dice</param>
        /// <returns>Number of ways to get sum of 10 when two dice is rolled</returns>
        /// <example>
        /// GET api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// GET api/J2/DiceGame/5/5 -> There is 1 way to get the sum 10.
        /// </example>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            int solutions = 0;
            for(int i = 1; i<= m; i++)
            {
                for(int j = 1; j<= n; j++)
                {
                    if(i+j == 10)
                    {
                        solutions++;
                    }
                }
            }
            if(solutions == 1)
            {
                return "There is "+ solutions +" way to get the sum 10.";
            }
            else
            {
                return "There are "+ solutions +" total ways to get the sum 10.";
            }
            
        }
    }
}
