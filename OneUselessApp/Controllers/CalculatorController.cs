using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneUselessApp.Controllers
{
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
                    break;
                case "sub":
                    return (sn - fn).ToString();
                    break;
                case "div":
                    return (sn / fn).ToString();
                    break;
                case "mul":
                    return (sn * fn).ToString();
                    break;
                case "sqr":
                    return Math.Pow(fn, sn).ToString();
                    break;
                default:
                    return "operation not specifield";
                    break;
            }

        }

        [Route("api/calc/switch/{paramOne}/{paramTwo}/{paramThree}")]
        public string GET(float paramOne, float paramTwo, string paramThree)
        {
            return calculatorSwitch(paramOne, paramTwo, paramThree).ToString();

        }

    }
}