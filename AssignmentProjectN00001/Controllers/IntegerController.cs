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




        /// <summary>
        /// Divides a number by 2. Truncates the result
        /// </summary>
        /// <param name="id">The number to divide</param>
        /// <returns>the input number divided by 2</returns>
        /// <example>
        /// GET : localhost:xx/api/integer/-11 => -5
        /// </example>
        /// <example>
        /// GET : localhost:xx/api/integer/10 => 5
        /// </example>
        /// <example>
        /// GET : localhost:xx/api/integer/2 => 1
        /// </example>
        public int Get(int id)
        {
            int result = id / 2;
            return result;
        }



    }
}
