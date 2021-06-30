using System;

namespace VoidwyrmCoreAPI.core.events.models
{
    public class PlayerConnected : EventArgs
    {
        public int SomethingRandom { get; set; }

        public dynamic DataObject { get; set; }
    }
}