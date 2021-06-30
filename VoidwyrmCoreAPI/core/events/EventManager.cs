namespace VoidwyrmCoreAPI.core.events
{
    using System;
    using global::VoidwyrmCoreAPI.core.events.models;

    public class EventManager
    {
        public event EventHandler<CoreEvent> CustomEvent; 
        public event EventHandler<CoreEvent> CustomOverride; 
        public event EventHandler<CoreEvent> CustomCommand; 

        public event EventHandler<PlayerDisconnected> PlayerDisconnected;
        public event EventHandler<PlayerConnected> PlayerConnected;

        public virtual void OnPlayerConnected(PlayerConnected e)
        {
            PlayerConnected?.Invoke(this, e);
        }
        public virtual void OnPlayerDisconnected(PlayerDisconnected e)
        {
            PlayerDisconnected?.Invoke(this, e);
        }

        public virtual void OnCustomCommand(CoreEvent e)
        {
            CustomCommand?.Invoke(this, e);
        }

        public virtual void OnCustomOverride(CoreEvent e)
        {
            CustomOverride?.Invoke(this, e);
        }

        public virtual void OnCustomEvent(CoreEvent e)
        {
            CustomEvent?.Invoke(this, e);
        }
    }
}