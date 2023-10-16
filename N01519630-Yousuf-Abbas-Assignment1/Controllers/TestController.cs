using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01519630_Yousuf_Abbas_Assignment1.Controllers
{
    public class TestController : ApiController
    {
        //Returns 10 more than the integer input {id}.

        [HttpGet]
        [Route("api/addTen/{id}")]



        public int addTen(int id)
        {
            int product = id + 10;
            return product;
        }
        //Returns the square of the integer input {id}
        [HttpGet]

        [Route("api/square/{id}")]


        public int square(int id)
        {
            int product = id * id;
            return product;
        }

        //Returns the string “Hello World!”

        [HttpPost]
        [Route("api/greeting")]

        public string greeting()
        {

            return "Hello world!";
        }

        //Returns the string “Greetings to {id} people!” where id is an integer value.

        [HttpGet]
        [Route("api/greeting/{id}")]
        public string greeting2(int id)
        {

            return "Greetings to " + id + "people";

        }


        //Create a method which has an input {id}, and applies four mathematical operations to it.




        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public int NumberMachine(int id)
        {

            int result = (id * 10) / 5 + 2 - id;
            return result;

        }


        [HttpGet]
        [Route("api/HostingCost/{id}")]

        public string[] ini(int id)
        {
            int fortNight = id / 14 + 1;
            double costBeforeTax = fortNight * 5.50;
            double costAfterTax = costBeforeTax * 1.13;
            double tax = 0.13 * costBeforeTax;

            string HST = "HST 13% = " + tax + "CAD";
            string total = costAfterTax + " CAD";
            string fortNightCost = fortNight + " fortNight at $5.50/FN =" + costBeforeTax;
            //1 fortnights at $5.50/FN = $5.50 CAD”
            string[] myNum = { fortNightCost, HST, total };

            return myNum;







        }
    }
}
