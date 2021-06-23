using VoidILibrary;

namespace VoidwyrmCoreAPI.events
{
    using System;

    public class EventManager: IEventManager
    {
        public event EventHandler<EventArgs> PlayerJoined;
    }
}