using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppAttDela.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            string tmp = Get(2);
            return new string[] { tmp, "Kurt", "rolf1", "anna", "value1" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string stringtest = "id" + "1";
            return stringtest;
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
    }
}
