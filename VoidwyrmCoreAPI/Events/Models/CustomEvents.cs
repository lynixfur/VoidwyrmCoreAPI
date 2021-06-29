namespace VoidwyrmCoreAPI.Events.Models
{
    using global::VoidwyrmCoreAPI.core.interfaces;

    public class CustomEvents
    {
        public string Type { get; set; }
        public string source { get; set; }
        public bool CustomEvent { get; set; }
        public IDataProps DataProps { get; set; }
    }
}