namespace VoidwyrmCoreAPI.core.events
{
    using System;
    using global::VoidwyrmCoreAPI.core.events.models;

    public class EventManager
    {
        //custom events
        public event EventHandler<CoreEvent> CustomEvent; 
        public event EventHandler<CoreEvent> CustomOverride; 
        public event EventHandler<CoreEvent> CustomCommand; 

        // Voidwyrm Events
        public event EventHandler<PlayerDisconnected> PlayerDisconnected;
        public event EventHandler<PlayerConnected> PlayerConnected;
        public event EventHandler<EntityKilled> EntityKilled;
        public event EventHandler<ChatMessage> ChatMessage;
        public event EventHandler<ServerStarted> ServerStarted;
        public event EventHandler<WeaponDamage> WeaponDamage;

        public virtual void OnPlayerConnected(CoreEvent e)
        {
            PlayerConnected joinEvent = e.DataProps;

            joinEvent.ClusterId = e.ClusterId;
            joinEvent.ServerId = e.ServerId;
            joinEvent.ServerName = e.ServerName;

            PlayerConnected?.Invoke(this, joinEvent);
        }
        public virtual void OnPlayerDisconnected(CoreEvent e)
        {
            PlayerDisconnected leaveEvent = e.DataProps;

            leaveEvent.ClusterId = e.ClusterId;
            leaveEvent.ServerId = e.ServerId;
            leaveEvent.ServerName = e.ServerName;

            PlayerDisconnected?.Invoke(this, leaveEvent);
        }

        public virtual void OnEntityKilled(CoreEvent e)
        {
            EntityKilled killedEvent = e.DataProps;

            killedEvent.ClusterId = e.ClusterId;
            killedEvent.ServerId = e.ServerId;
            killedEvent.ServerName = e.ServerName;

            EntityKilled?.Invoke(this, killedEvent);
        }

        public virtual void OnChatMessage(CoreEvent e)
        {
            ChatMessage chatEvent = e.DataProps;

            chatEvent.ClusterId = e.ClusterId;
            chatEvent.ServerId = e.ServerId;
            chatEvent.ServerName = e.ServerName;

            ChatMessage?.Invoke(this, chatEvent);
        }

        public virtual void OnServerStarted(CoreEvent e)
        {
            ServerStarted serverStartedEvent = e.DataProps;

            serverStartedEvent.ClusterId = e.ClusterId;
            serverStartedEvent.ServerId = e.ServerId;
            serverStartedEvent.ServerName = e.ServerName;

            ServerStarted?.Invoke(this, serverStartedEvent);
        }

        protected virtual void OnWeaponDamage(CoreEvent e)
        {
            WeaponDamage weaponDamageEvent = e.DataProps;

            weaponDamageEvent.ClusterId = e.ClusterId;
            weaponDamageEvent.ServerId = e.ServerId;
            weaponDamageEvent.ServerName = e.ServerName;

            WeaponDamage?.Invoke(this, weaponDamageEvent);
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