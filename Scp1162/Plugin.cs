using Exiled.API.Features;
namespace SCP1162
{
    public class Plugin : Plugin<Config, Translations>
    {
        public override string Prefix => "Scp-1162";
        public override string Name => "Scp-1162";
        public override string Author => "Mariki";
        public override System.Version Version { get; } = new System.Version(1, 0, 0);
        public static Plugin Instance;
        public EventHandler EventHandler;


        public override void OnEnabled()
        {
            Instance = this;
            EventHandler = new EventHandler();
            Exiled.Events.Handlers.Player.PickingUpItem += EventHandler.PickingScp1162;
            Exiled.Events.Handlers.Server.RoundStarted += EventHandler.OnRoundStart;
            base.OnEnabled();

        }
        public override void OnDisabled()
        {
            Instance = this;
            EventHandler = new EventHandler();
            Exiled.Events.Handlers.Player.PickingUpItem -= EventHandler.PickingScp1162;
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandler.OnRoundStart;
            base.OnDisabled();


        }

    }

}

