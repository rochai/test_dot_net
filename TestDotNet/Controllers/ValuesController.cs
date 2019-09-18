using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestDotNet.Services;
using Unity;

namespace TestDotNet.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        [Dependency]
        public IRozTestService RozTestService { get; set; }

        // GET api/values
        public IHttpActionResult Get()
        {
            try
            {
                var roz = RozTestService.GetAll();
                if (roz == null)
                    return NotFound();
                
                return Ok(roz);
            }
            catch (Exception ex)
            {
                // Log it somewhere
                return InternalServerError(ex);
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
