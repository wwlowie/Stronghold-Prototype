using System.Web.Http;

namespace Stronghold_Prototype.Controllers
{
    [RoutePrefix("api/hello")]
    public class HelloController : ApiController
    {
        [Route]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return BadRequest("Hello World!"); // "Hello World!";

        }
    }
}