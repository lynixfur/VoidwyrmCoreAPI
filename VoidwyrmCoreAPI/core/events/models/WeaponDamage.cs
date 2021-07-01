namespace VoidwyrmCoreAPI.core.events.models
{
    public class WeaponDamage : VoidwyrmEvent
    {
        public double Damage { get; set; }
        public string WeaponPath { get; set; }
        public string SteamId { get; set; }
        public string TribeId { get; set; }
    }
}
