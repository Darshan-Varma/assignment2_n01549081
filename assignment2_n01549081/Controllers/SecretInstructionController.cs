using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2_n01549081.Controllers
{
    public class SecretInstructionController : ApiController
    {
        /// <summary>
        /// Decoding secret instructions
        /// URL : https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2021/index.html
        /// </summary>
        /// <param name="code">Passing the code which needs to be decoded</param>
        /// <returns>Decodes the first two digit to the direction after getting the sum of them</returns>
        /// <example>
        /// GET api/J3/SecretInstruction/57234 00907 34100 99999 -> right234 right907 left100
        /// </example>
        [Route("api/J3/SecretInstruction/{code}")]
        [HttpGet]
        public IEnumerable<string> SecretInstruction(string code)
        {   
            List<string>decodedInstruction = new List<string>();
            List<string> secretInstructions = code.Split(' ').ToList();
            List<string> listOfDirections = new List<string>();
            foreach (var secretCode in secretInstructions)
            {
                var intDirection = Convert.ToInt32(secretCode.Substring(0, 2));
                var secondPart = secretCode.Substring(2);
                var direction = "";
                var count = 0;
                while (intDirection > 0)
                {
                    count += intDirection % 10;
                    intDirection = intDirection / 10;
                }
                if (count > 0)
                {
                    if (count % 2 == 1)
                    {
                        direction = "left ";
                    }
                    else if (count % 2 == 0 && count != 0)
                    {
                        direction = "right ";
                    }
                    listOfDirections.Add(direction);
                }
                if(count == 0)
                {
                    direction = listOfDirections.LastOrDefault();
                    listOfDirections.Add(direction);
                }

                decodedInstruction.Add(direction + secondPart);
            }
            if (decodedInstruction.Any())
            {
                decodedInstruction.RemoveAt(decodedInstruction.Count - 1);
            }
            return decodedInstruction;
        }
    }
}
