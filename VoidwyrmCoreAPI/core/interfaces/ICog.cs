﻿using VoidwyrmLib;

namespace VoidwyrmCoreAPI.core.interfaces
{
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
