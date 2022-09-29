using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// takes a number and performs 3 arithmetic opperations 
        /// </summary>
        /// <param name="id">
        /// the number you want to opertate on
        /// </param>
        /// <returns>
        /// returns double of id plus 10
        /// </returns>
        // GET api/NumberMachine{id = 1}
        //returns 12
        public int Get(int id)
        {
            // do some mathematical operations on id
            int answer = id * 2 + 20 / 2;
            return answer;
        }
    }
}
