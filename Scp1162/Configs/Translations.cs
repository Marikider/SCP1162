using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SCP1162.Configs
{
    public class Translations : ITranslation

    {
        [Description("Message sent when interacting with Scp-1162 without holding an item in hand")]
        public string DamageHint { get; set; } = "<color=red>Dont stick your Hand in unknown holes ( ͡° ͜ʖ ͡° )</color>";
        [Description("Message sent when interacting with Scp-1162")]
        public string InteractionHint { get; set; } = "<i>You put an item into </i><color=yellow>SCP-1162</color><i> and got Another!</i>";
        [Description("Message sent when the item disappears")]
        public string LostItemHint { get; set; } = "<color=red>You lost your item</color>";
    }
}