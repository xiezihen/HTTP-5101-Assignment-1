using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// squares the number
        /// </summary>
        /// <param name="id">
        /// number to be  squared
        /// </param>
        /// <returns>
        /// returns the square of id
        /// </returns>
        // GET api/square/5
        // returns 25
        public int Get(int id) {
            // returns id squared
            return (int)Math.Pow(id, 2);
        }
    }
}
