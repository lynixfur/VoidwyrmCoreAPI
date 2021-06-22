namespace VoidwyrmCoreAPI.events
{
    using System;

    public class EventManager
    {
        public EventHandler<HttpRequest> HttpRequestRecieved;
        public EventHandler<Player_Joined> PlayerJoined;
        public EventHandler<Player_Left> PlayerLeft;
    }

    public class Player_Joined
    {
        public string name { get; set; }
        public string steamid { get; set; }
    }
}