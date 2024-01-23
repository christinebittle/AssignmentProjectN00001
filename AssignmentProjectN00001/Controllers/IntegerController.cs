using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentProjectN00001.Controllers
{
    public class IntegerController : ApiController
    {

        //GET : localhost:xx/api/integer => 1
        public int Get()
        {

            return 1;
        }

        //GET : localhost:xx/api/integer/5 => 5
        public int Get(int id)
        {

            return id;
        }



    }
}
