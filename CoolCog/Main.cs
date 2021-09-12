using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;
using System;
using System.Threading.Tasks;
using Discord.WebSocket;
using Discord;

namespace CoolCog
{
    using VoidwyrmCoreAPI.core;
    using VoidwyrmCoreAPI.core.events;

    public class Main : ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public string CogPublishID { get; set; }
        
        public Certificate CertificateObject {get; set;}

        private EventManager eventManager;
        private EventHandler eventHandler;

        public Main()
        {
            CogName = "CoolCog";
            CogVersion = 1.7f;
            CogDescription = "This Cool Ass Cog";
            CogPublishID = "ckq9timk5000001kzeb5d06bl";
            CertificateObject = null;
        }

        public void Configure()
        {

        }

        private DiscordSocketClient _client;
        public void OnLoad(EventManager _eventManager)
        {
            //Load Discord Bot
            new Main().MainAsync(_eventManager).GetAwaiter().GetResult();
        
        }
        public async Task MainAsync(EventManager _eventManager)
	    {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            _client.MessageReceived += MessageHandler;
            var token = "ODU5Nzg1ODIxNjI3ODc1MzM4.YNxv8Q.hiLkIzukPitYfooN4CZjGyRy48o";
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();


            eventManager = _eventManager;
            eventHandler = new EventHandler(eventManager,_client);
            
            Task.WaitAll(SubscribeEvent());
            VoidLogger.Log(LogObject.LogType.Error, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "This cog is under testing and may be broken!");
            
	    }

        private Task MessageHandler(SocketMessage arg)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"{arg.Author.Username} -> {arg.Content}");
            return Task.CompletedTask;
        }

        private Task Log(LogMessage arg)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, arg.Message);
            return Task.CompletedTask;
        }

        public async Task SubscribeEvent()
        {
            await eventHandler.Subscribe();
        }


        public void OnUnload()
        {

        }

        int Voidwyrms = 0;

        public void addVoidwyrm() {
            Voidwyrms++;
            Console.WriteLine($"There are {Voidwyrms} voidwyrms!");
        }

        public void SubscribedEvent() 
        {

        }

        public void EventHandler(string dataProps)
        {
            addVoidwyrm();
            Console.WriteLine($"{dataProps}");
        }

        public void AdditionalConfigurations(string dataProps) 
        {

        }

        public void AdditionalOverrides(string dataProps) 
        {

        }

        public void AdditionalApiEndpoints() 
        {

        }
    }
}