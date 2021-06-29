namespace VoidwyrmCoreAPI.Events
{
    using System;
    using PlayerJoin = global::VoidwyrmCoreAPI.Events.Models.PlayerJoin;

    public class EventManager
    {
        public event EventHandler<PlayerJoin> PlayerJoined; 
        public event EventHandler<PlayerLeave> PlayerJoined; 
        public event EventHandler<PlayerDied> PlayerJoined; 

        public virtual void OnPlayerJoined(PlayerJoin e)
        {
            if (PlayerJoined != null) PlayerJoined(this, e);
        }
    }

    public class PlayerLeave { }
}