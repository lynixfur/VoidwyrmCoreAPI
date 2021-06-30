namespace VoidwyrmCoreAPI.core.events
{
    using System;
    using global::VoidwyrmCoreAPI.core.Enums;

    public class CoreEvent : EventArgs
    {
        public EventTypes DataType { get; set; }
        public string DataSource { get; set; }
        public string ServerId { get; set; }
        public string ClusterId { get; set; }
        public string ServerName { get; set; }
        public string MapName { get; set; }
        public string EventName { get; set; }
        public dynamic DataProps { get; set; }
    }
}