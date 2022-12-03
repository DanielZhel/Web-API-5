using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetingController : ControllerBase
    {
        private readonly RoomSettings _settings;
        public MeetingController(IOptions<RoomSettings> options)
        {
            _settings = options.Value;
          
        }

        [HttpGet]
        public IEnumerable<RoomSettings> Get()
        {

            return Enumerable.Range(1, 1).Select(index => new RoomSettings
            {
                PeopleNumber = _settings.PeopleNumber,
                MaxMeetingTime = _settings.MaxMeetingTime,
            })
            .ToArray();
        }
    }
}
