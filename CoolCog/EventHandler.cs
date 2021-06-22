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

        public Task InitializeListener()
        {
            eventManager.PlayerJoined += async (source, _args) =>
            {
                await OnPlayerJoin(_args);
            }
        }

        private async Task OnPlayerJoin(Player_Joined playerJoined)
        {
            
        }
    }
}