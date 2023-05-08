using System.Web.Http;

namespace Stronghold_Prototype.Controllers
{
    [RoutePrefix("api/session-logs")]
    public class SessionLogsController: ApiController
    {
        [Route]
        [HttpPost]
        public IHttpActionResult CreateSessionLog([FromBody] SessionLogDto sessionLogDto)
        {
            if (sessionLogDto == null)
                return BadRequest();
            return Ok(sessionLogDto);
        }
    }

    
}