namespace VoidwyrmCoreAPI.core.events.models
{
    using global::VoidwyrmCoreAPI.core.events.models.SourceEvents;

    public class EntityKilled : VoidwyrmEvent
    {
        public string ActorClassKilled { get; set; }
        public string ActorClassKiller { get; set; }
        public string KilledName { get; set; }
        public string KillerName { get; set; }
        public string KilledLevel { get; set; }
        public string KillerLevel { get; set; }
        public string KilledTribe { get; set; }
        public string KillerTribe { get; set; }

    }
}
