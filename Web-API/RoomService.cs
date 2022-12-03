using Microsoft.Extensions.Options;

namespace Web_API
{
    public class RoomService
    {
        private readonly RoomSettings _settings;
        public RoomService(IOptions<RoomSettings> options)
        {
            _settings = options.Value;
        }

        public string GetSettings()
        {
            return $"MaxPeople:{_settings.PeopleNumber} , MeetingTime {_settings.PeopleNumber}";
        }


    }
}
