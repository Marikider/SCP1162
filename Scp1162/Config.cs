using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace SCP1162
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
        [Description("Should a user get damaged when interacting with Scp-1162 without holding an item in hand")]
        public bool ShouldDamage { get; set; } = true;
        [Description("Message sent when interacting with Scp-1162 without holding an item in hand")]
        public string DamageHint { get; set; } = "<color=red>Dont stick your Hand in unknown holes ( ͡° ͜ʖ ͡° )</color>";
        [Description("Minimum Health to use Scp-1162")]
        public int HealthMinus { get; set; } = 25;
        [Description("Message sent when interacting with Scp-1162")]
        public string InteractionHint { get; set; } = "<i>You put an item into </i><color=yellow>SCP-1162</color><i> and got Another!</i>";
        [Description("The chance that the item disappears in % (set to 0 to disable)")]
        public float PercentDisappearing { get; set; } = 40;
        [Description("Message sent when the item disappears")]
        public string LostItemHint { get; set; } = "<color=red>You lost your item</color>";
        [Description("What items should Scp-1162 be able to give")]
        public List<ItemType> ItemsToGive { get; set; } = new List<ItemType>
        {
            ItemType.KeycardO5,
            ItemType.SCP500,
            ItemType.KeycardMTFOperative,
            ItemType.GunCOM15,
            ItemType.SCP207,
            ItemType.Adrenaline,
            ItemType.GunCOM18,
            ItemType.KeycardFacilityManager,
            ItemType.Medkit,
            ItemType.KeycardMTFCaptain,
            ItemType.KeycardGuard,
            ItemType.GrenadeHE,
            ItemType.KeycardZoneManager,
            ItemType.KeycardGuard,
            ItemType.Radio,
            ItemType.GrenadeFlash,
            ItemType.KeycardScientist,
            ItemType.KeycardJanitor,
            ItemType.Coin,
            ItemType.Flashlight
        };

    }
}
