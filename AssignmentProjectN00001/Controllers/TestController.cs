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

        //GOAL: 
        //GET localhost:xx/api/test/christine -> "Hello christine"

        public string Get(string id) 
        {
            string message = "Hello " + id;
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
