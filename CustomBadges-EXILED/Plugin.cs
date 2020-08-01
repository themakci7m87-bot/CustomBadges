namespace CustomBadges
{
    using Exiled.API.Enums;
    using Exiled.API.Features;

    public class Plugin : Plugin<Config>
    {
        private Handlers Handlers;

        public override PluginPriority Priority => PluginPriority.Lower;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Handlers = new Handlers();
            Handlers.Badges = Config.Badges;

            Exiled.Events.Handlers.Player.Joined += Handlers.OnJoined;
            Exiled.Events.Handlers.Server.SendingConsoleCommand += Handlers.OnSendingConsoleCommand;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Player.Joined -= Handlers.OnJoined;
            Exiled.Events.Handlers.Server.SendingConsoleCommand -= Handlers.OnSendingConsoleCommand;

            Handlers.Badges = null;
            Handlers = null;
        }

        public override void OnReloaded() => base.OnReloaded();
    }
}
