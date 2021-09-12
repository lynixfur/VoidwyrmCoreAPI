namespace VoidwyrmCoreAPI.core.events.models
{
    using global::VoidwyrmCoreAPI.core.events.models.SourceEvents;

    public class PlayerDisconnected : VoidwyrmEvent
    {
        public string SteamId { get; set; }
        public string TribeId { get; set; }
        public string PlayerId { get; set; }
    }
}