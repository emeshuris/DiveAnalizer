using System.Threading.Tasks;
using System.Web.Http;

namespace DiveAnalyzer.API.Controllers
{
    public class DiveController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            var Dives = await DAL.DAL.AsyncGetDives();

            return Ok(Dives);
        }

        // GET: api/Dive/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Dive
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dive/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dive/5
        public void Delete(int id)
        {
        }
    }
}
