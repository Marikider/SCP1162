using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP1162
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool ShouldHeart { get; set; } = true;
        public string HeartHint { get; set; } = "<color=red>Do not use SCP-1162 with no item handed!</color>";
        public int HealthMinus { get; set; } = 15;
        public string InteraktingHint { get; set; } = "<color=yellow>You Have Used SCP-1162 and You've Changed Your Item!</color>";
        
        public List<ItemType> ItemsToGive { get; set; } = new List<ItemType>
        {
            ItemType.KeycardO5,
            ItemType.SCP500,
            ItemType.MicroHID,
            ItemType.KeycardNTFCommander,
            ItemType.KeycardContainmentEngineer,
            ItemType.SCP268,
            ItemType.GunCOM15,
            ItemType.SCP207,
            ItemType.Adrenaline,
            ItemType.GunCOM18,
            ItemType.KeycardFacilityManager,
            ItemType.Medkit,
            ItemType.KeycardNTFLieutenant,
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
