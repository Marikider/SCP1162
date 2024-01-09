using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;
namespace SCP1162
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "Scp-1162";
        public override string Name => "Scp-1162";
        public override string Author => "Mariki";
        public override System.Version Version { get; } = new System.Version(1, 0, 0);
        public static Plugin plugin;
        public EventHandler EventHandler;


        public override void OnEnabled()
        {
            plugin = this;
            EventHandler = new EventHandler();
            Exiled.Events.Handlers.Player.PickingUpItem += EventHandler.PickingScp1162;
            Exiled.Events.Handlers.Server.RoundStarted += EventHandler.OnRoundStart;
            base.OnEnabled();

        }
        public override void OnDisabled()
        {
            plugin = this;
            EventHandler = new EventHandler();
            Exiled.Events.Handlers.Player.PickingUpItem -= EventHandler.PickingScp1162;
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandler.OnRoundStart;
            base.OnDisabled();


        }

    }

}

