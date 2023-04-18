using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Stronghold_Prototype.Controllers
{
    [RoutePrefix("api/session-logs")]
    public class SessionLogsController: ApiController
    {
        [Route]
        [HttpPost]
        public IHttpActionResult CreateSessionLog([FromBody] SessionLogDTO sessionLogDTO)
        {
            if (sessionLogDTO == null)
                return BadRequest();
            return Ok(sessionLogDTO);
        }
    }

    
}