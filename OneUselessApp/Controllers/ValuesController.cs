using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneUselessApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Julius", "Chinwe", "Sadiq" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            if(id == 1)
            {
            return "julius";

            }
            else
            {
                return "Chinwe";
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public class Calc
        {
            public string CrudOperation(float fn, float sn, string op)
            {
                if(op == "add")
                {
                    return (sn + fn).ToString();
                }else if(op == "sub")
                {
                    return (sn - fn).ToString();

                }
                else if(op == "mul")
                {
                    return (sn * fn).ToString();
                }
                else if(op == "div")
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

            public float Add(float fn, float sn)
            { return (sn + fn); }

            public float Sub(float fn, float sn)
            { return (sn - fn); }

            public float Mul(float fn, float sn)
            { return (sn * fn); }

            public float Div(float fn, float sn)
            { return (sn / fn); }
        }


        Calc nCalc = new Calc();

        [Route("api/calc/{paramOne}/{paramTwo}/{paramThree}")]
        public string Get(float paramOne, float paramTwo, string paramThree)
        {
            return nCalc.CrudOperation(paramOne, paramTwo, paramThree).ToString();

        }










        Calc oCalc = new Calc();

        [Route("api/calc/add/{paramOne}/{paramTwo}")]

        public float Get(float paramOne, float paramTwo)
        {
            return oCalc.Add(paramOne, paramTwo);

        }

        [Route("api/calc/sub/{paramOne}/{paramTwo}")]
        public IHttpActionResult GetSub(float paramOne, float paramTwo)
        {
            return Ok(oCalc.Sub(paramOne, paramTwo));
        }

        [Route("api/calc/mul/{paramOne}/{paramTwo}")]
        public IHttpActionResult GetMul(float paramOne, float paramTwo)
        {
            return Ok(oCalc.Mul(paramOne, paramTwo));
        }

        [Route("api/calc/div/{paramOne}/{paramTwo}")]
        public IHttpActionResult GetDiv(float paramOne, float paramTwo)
        {
            return Ok(oCalc.Div(paramOne, paramTwo));
        }

    }

}

