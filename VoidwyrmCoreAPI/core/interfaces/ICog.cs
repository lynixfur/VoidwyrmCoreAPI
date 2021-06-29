namespace VoidwyrmCoreAPI.core.interfaces
{
    using global::VoidwyrmCoreAPI.Events;

    public interface ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }
        public string CogPublishID { get; set; }

        void Configure();
        void OnLoad(EventManager eventManager);
        void OnUnload();
<<<<<<< Updated upstream
        void EventHandler();
=======
        void EventHandler(string httpData);

        void AdditionalConfigurations(string httpData);
>>>>>>> Stashed changes
    }
}
