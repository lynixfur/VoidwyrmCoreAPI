namespace VoidwyrmCoreAPI.core.events.models.SourceEvents
{
    using System;

    public class VoidwyrmEvent : EventArgs
    {
        public string ServerId { get; set; }
        public string ClusterId { get; set; }
        public string ServerName { get; set; }
    }
}
