using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting
        // returns "Hello World"
        /// <summary>
        /// when no id is specified it will sa hello world
        /// </summary>
        /// <returns>
        /// returns hello world
        /// </returns>
        public string Post()
        {
            //returns greeting when id is not specified
            return "Hello World";
        }
        /// <summary>
        /// when a number of people is specified in this route send a mesage that will greet them
        /// </summary>
        /// <param name="id">
        ///  id is the number of people to greet
        /// </param>
        /// <returns>
        /// returns a mesage that greets id number of people
        /// </returns>
        // GET api/Greeting/{id = 1}
        // returns "Greetings to 1 people"
        public string Get(int id)
        {
            //if id is specified return string that greets {id} number of people
            return "Greetings to " + id +" people!";
        }
    }
}
