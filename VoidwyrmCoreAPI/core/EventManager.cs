using System;
using VoidwyrmCoreAPI.core.events.models;

namespace VoidwyrmLib
{
    public class EventManager
    {
        public event EventHandler<PlayerConnected> PlayerConnected; 
        public event EventHandler<PlayerDisconnected> PlayerDisconnected; 

        public virtual void OnPlayerConnected(PlayerConnected e)
        {
            if (PlayerConnected != null) PlayerConnected(this, e);
        }
        public virtual void OnPlayerDisconnected(PlayerDisconnected e)
        {
            if (PlayerDisconnected != null) PlayerDisconnected(this, e);
        }
    }
}