using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// adds ten to the number given
        /// </summary>
        /// <param name="id">
        /// number that wil be squared
        /// </param>
        /// <returns>
        /// returns the square of id
        /// </returns>
        // GET api/addten/5
        //returns 15
        public int Get(int id)
        {
            // returns id + 10
            return id+10;
        }


    }
}
