using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentProjectN00001.Controllers
{
    public class TestController : ApiController
    {


        /// <summary>
        /// Creates a greeting message for a person
        /// </summary>
        /// <param name="id">the name of the person to greet</param>
        /// <returns>Hello {name}!</returns>
        /// <example>
        /// GET: localhost:xx/api/test/christine => "Hello christine!"
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/test/Sean => "Hello Sean!"
        /// </example>
        public string Get(string id) 
        {
            string message = "Hello " + id+"!";
            return message;
        }

        //GOAL:
        //POST localhost:xx/api/test -> "Post Request!"

        public string Post()
        {
            return "Post Request!";
        }


    }
}
