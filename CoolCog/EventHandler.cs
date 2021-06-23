namespace CoolCog
{
    using System.Threading.Tasks;
    using VoidwyrmCoreAPI.events;

    public class EventHandler
    {
        private readonly EventManager eventManager;

        public EventHandler(EventManager _eventManager)
        {
            eventManager = _eventManager;
        }
    }
}