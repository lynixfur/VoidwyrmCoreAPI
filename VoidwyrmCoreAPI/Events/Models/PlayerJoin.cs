namespace VoidwyrmCoreAPI.Events.Models
{
    using System;

    public class PlayerJoin : EventArgs
    {
        public int SomethingRandom { get; set; }
    }
}