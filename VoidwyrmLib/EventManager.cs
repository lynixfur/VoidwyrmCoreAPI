namespace VoidwyrmLib
{
    using System;
    using VoidwyrmLib.Models;

    public class EventManager
    {
        public event EventHandler<PlayerJoin> PlayerJoined; 

        public virtual void OnPlayerJoined(PlayerJoin e)
        {
            if (PlayerJoined != null) PlayerJoined(this, e);
        }
    }
}