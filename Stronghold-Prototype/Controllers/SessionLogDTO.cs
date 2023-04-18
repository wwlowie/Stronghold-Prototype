using System.Collections.Generic;

namespace Stronghold_Prototype.Controllers
{
    public class SessionLogDTO
    {
        public string topicID;
        public string sessionDateISO;
        public string sessionTimeISO;
        public string durationISO;
        public string recorderName;
        public List<string> mentorDiscordUserIds;
        public List<attendeesGTO> attendees;
    }

    public class attendeesGTO
    {
        public string discordUserId;
        public string attendanceDurationISO;
    }
}