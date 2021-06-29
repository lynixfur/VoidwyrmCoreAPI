namespace VoidwyrmCoreAPI.Events.Models
{
    using global::VoidwyrmCoreAPI.core.interfaces;

    public class CustomDataProps : IDataProps
    {
        public string ServerName { get; set; }
        public string ServerId { get; set; }
        public string CluserId { get; set; }
        public string SteamId { get; set; }
        public string Test { get; set; }
    }
}