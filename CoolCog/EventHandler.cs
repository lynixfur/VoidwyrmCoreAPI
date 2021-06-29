namespace CoolCog
{
    using System;
    using System.Threading.Tasks;
    using VoidwyrmCoreAPI.Events;
    using VoidwyrmCoreAPI.Events.Models;

    public class EventHandler
    {
        private readonly EventManager eventManager;

        public EventHandler(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public async Task Subscribe()
        {
            eventManager.PlayerJoined += OnPlayerJoined;

            await Task.CompletedTask;
            TestTask();
        }

        private void OnPlayerJoined(object source, PlayerJoin args)
        {
            Console.WriteLine("worked");
        }

        private void TestTask()
        {
            var x = new PlayerJoin
                    {
                        SomethingRandom = 1
                    };
            
            eventManager.OnPlayerJoined(x);
        }
    }
}