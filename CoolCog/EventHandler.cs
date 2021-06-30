namespace CoolCog
{
    using System;
    using System.Threading.Tasks;
    using VoidwyrmCoreAPI.core.events.models;
    using VoidwyrmCoreAPI.core.logger;
    using VoidwyrmLib;

    public class EventHandler
    {
        private readonly EventManager eventManager;

        public EventHandler(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public async Task Subscribe()
        {
            eventManager.PlayerConnected += OnPlayerConnected;
            eventManager.PlayerDisconnected += OnPlayerDisconnected;

            await Task.CompletedTask;
        }

        private void OnPlayerConnected(object source, PlayerConnected args)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"Event Fired! -> PlayerDisconnected (Data : {args.SomethingRandom})");
        }

        private void OnPlayerDisconnected(object source, PlayerDisconnected args)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"Event Fired! -> PlayerDisconnected (Data : {args.SomethingRandom})");
        }

        /*private void TestTask()
        {
            var x = new PlayerJoin
                    {
                        SomethingRandom = 1
                    };

            eventManager.OnPlayerJoined(x);
        }*/
    }
}