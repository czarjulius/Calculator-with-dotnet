using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneUselessApp.Controllers
{
    [Route("api/{controller}")]
    public class CalculatorController : ApiController
    {
        public string CrudOperation(float fn, float sn, string op)
        {
            if (op == "add")
            {
                return (sn + fn).ToString();
            }
            else if (op == "sub")
            {
                return (sn - fn).ToString();

            }
            else if (op == "mul")
            {
                return (sn * fn).ToString();
            }
            else if (op == "div")
            {
                return (sn / fn).ToString();
            }
            else if (op == "sqr")
            {
                return Math.Pow(fn, sn).ToString();
            }
            else
            {
                return "operation not specifield";
            }
            

        }


        [Route("api/calc/if/{paramOne}/{paramTwo}/{paramThree}")]
        public string Get(float paramOne, float paramTwo, string paramThree)
        {
            return CrudOperation(paramOne, paramTwo, paramThree).ToString();

        }
        // check command 
        public string calculatorSwitch(float fn, float sn, string command)
        {
            switch (command)
            {
                case "add":
                    return (sn + fn).ToString();
                case "sub":
                    return (sn - fn).ToString();
                case "div":
                    return (sn / fn).ToString();
                case "mul":
                    return (sn * fn).ToString();
                case "sqr":
                    return Math.Pow(fn, sn).ToString();
                default:
                    return "operation not specifield";
            }

        }

        [Route("api/calc/switch/{paramOne}/{paramTwo}/{paramThree}")]
        public string GET(float paramOne, float paramTwo, string paramThree)
        {
            return calculatorSwitch(paramOne, paramTwo, paramThree).ToString();

        }

    }
}