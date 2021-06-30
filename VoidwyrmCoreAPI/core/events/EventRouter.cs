using System;
using VoidwyrmCoreAPI.core.events.models;
using VoidwyrmLib;

namespace VoidwyrmCoreAPI.core.events
{    
    public class EventRouter
    {
        private EventManager eventManager;
        public EventRouter(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public void RouteEvent(dynamic data) 
        {
            switch((string)data.EventName) {
                case "PlayerConnected":
                        eventManager.OnPlayerConnected(new PlayerConnected
                        {
                            SomethingRandom = 1053,
                            DataObject = data
                        });
                        break;
                case "PlayerDisconnected":
                        eventManager.OnPlayerDisconnected(new PlayerDisconnected
                        {
                            SomethingRandom = 500
                        });
                        break;
                default:
                        Console.WriteLine("Custom Event!");
                        break;                        
            }
        }
    }
}