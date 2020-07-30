namespace CustomBadges
{
    using Exiled.API.Enums;
    using Exiled.API.Features;

    public class Plugin : Plugin<Config>
    {
        private Handlers.Player player;

        public override PluginPriority Priority => PluginPriority.Lower;

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;

            base.OnEnabled();
            player = new Handlers.Player();
            player.Badges = Config.Badges;
            Exiled.Events.Handlers.Player.Joined += player.OnJoined;

        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Player.Joined -= player.OnJoined;
            player.Badges = null;
            player = null;
        }
    }
}
