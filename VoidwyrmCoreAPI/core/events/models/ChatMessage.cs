namespace VoidwyrmCoreAPI.core.events.models
{
    using global::VoidwyrmCoreAPI.core.events.models.SourceEvents;

    public class ChatMessage : VoidwyrmEvent
    {
        public string Content { get; set; }
        public string PlayerName { get; set; }
        public string SteamId { get; set; }
        public string TribeId { get; set; }
        public bool IsCommand { get; set; }
        public string Map { get; set; }
        public string PlayerLevel { get; set; }
    }
}
