namespace VoidwyrmCoreAPI
{
    using System;
    using VoidILibrary;

    public sealed class test : IEventManager
    {
        public event EventHandler Player_Join
        {
            add => VoidwyrmCoreAPI.Player_Join += value;
            remove => VoidwyrmCoreAPI.Player_Join -= value;
        };
    }
}