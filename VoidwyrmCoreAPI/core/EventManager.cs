using System;
using VoidwyrmCoreAPI.core.events.models;

namespace VoidwyrmLib
{
    public class EventManager
    {
        public event EventHandler<PlayerJoin> PlayerJoined; 

        public virtual void OnPlayerJoined(PlayerJoin e)
        {
            if (PlayerJoined != null) PlayerJoined(this, e);
        }
    }
}