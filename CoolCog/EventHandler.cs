namespace CoolCog
{
    using System;
    using System.Threading.Tasks;
    using Discord;
    using Discord.WebSocket;
    using VoidwyrmCoreAPI.core;
    using VoidwyrmCoreAPI.core.events;
    using VoidwyrmCoreAPI.core.events.models;
    using VoidwyrmCoreAPI.core.logger;

    public class EventHandler
    {
        private readonly EventManager eventManager;
        private readonly DiscordSocketClient discordSocketClient;

        public EventHandler(EventManager eventManager, DiscordSocketClient client)
        {
            this.eventManager = eventManager;
            this.discordSocketClient = client;
        }

        public async Task Subscribe()
        {
            eventManager.PlayerConnected += OnPlayerConnected;
            eventManager.PlayerDisconnected += OnPlayerDisconnected;

            await Task.CompletedTask;
        }

        private void OnPlayerConnected(object source, PlayerConnected args)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"Event Fired! -> PlayerConnected (Data : {args.SteamId})");
            var testChannel = discordSocketClient.GetChannel((ulong)859785136220405790) as IMessageChannel;
            PlayerConnectedAsync(testChannel, args).GetAwaiter().GetResult();
        }

        public async Task PlayerConnectedAsync(IMessageChannel channel, PlayerConnected args)
	    {
            await channel.SendMessageAsync($"The Player has connected! ```{args.SteamId}```");
        }

        private void OnPlayerDisconnected(object source, PlayerDisconnected args)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"Event Fired! -> PlayerDisconnected (Data : {args.SteamId})");
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