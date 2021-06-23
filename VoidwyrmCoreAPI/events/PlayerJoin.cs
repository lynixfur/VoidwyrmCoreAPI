using System;
using VoidILibrary;

namespace VoidwyrmCoreAPI.events
{
    public sealed class PlayerJoin : EventArgs
    {
        public PlayerJoin ( int value )
        {
            ChangeInteger = value;
        }

        public int ChangeInteger { get; private set; }
    }
}