using System;
using VoidwyrmCoreAPI.core.events.models;

namespace VoidwyrmCoreAPI.core.events
{
    using global::VoidwyrmCoreAPI.core.Enums;
    using Newtonsoft.Json.Linq;

    public class EventRouter
    {
        private EventManager eventManager;
        public EventRouter(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public void RouteCoreEvent(CoreEvent data)
        {
            JObject eventObject = data.DataProps as JObject;


            switch(data.EventName) {
                case "PlayerConnected":
                    if (eventObject != null) eventManager.OnPlayerConnected(eventObject.ToObject<PlayerConnected>());
                    break;
                case "PlayerDisconnected":
                    if (eventObject != null) eventManager.OnPlayerDisconnected(eventObject.ToObject<PlayerDisconnected>());
                    break;                    
            }
        }

        public void RouteCustomEvent(CoreEvent data)
        {
            switch (data.DataType)
            {
                case EventTypes.CustomCommand:
                    eventManager.OnCustomCommand(data);
                    break;
                case EventTypes.CustomEvent:
                    eventManager.OnCustomEvent(data);
                    break;
                case EventTypes.CustomOverride:
                    eventManager.OnCustomOverride(data);
                    break;
            }
        }
    }
}