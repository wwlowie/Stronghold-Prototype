using System.Collections.Generic;

namespace Stronghold_Prototype.Controllers
{
    public class SessionLogDto
    {
        public string TopicId { get; set; }
        public string SessionDateIso { get; set; }
        public string SessionTimeIso { get; set; }
        public string DurationIso { get; set; }
        public string RecorderName { get; set; }
        public List<string> MentorDiscordUserIds { get; set; }
        public List<AttendeesDto> Attendees { get; set; }
    }

    public class AttendeesDto
    {
        public string DiscordUserId { get; set; }
        public string AttendanceDurationIso { get; set; }
    }
}