namespace VoidwyrmCoreAPI.core.interfaces
{
    using global::VoidwyrmCoreAPI.core.events;

    public interface ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }
        public string CogPublishID { get; set; }

        void Configure();
        void OnLoad(EventManager eventManager);
        void OnUnload();
        void EventHandler(string dataProps);

        void AdditionalConfigurations(string dataProps);
    }
}
