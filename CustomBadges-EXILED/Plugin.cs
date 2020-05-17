using EXILED;
using System.Collections.Generic;

namespace CustomBadges
{
    public class Plugin : EXILED.Plugin
    {
        public Dictionary<string, string> badges = 
            new Dictionary<string, string>();

        public Dictionary<string, string> users =
            new Dictionary<string, string>();

        private EventHandlers EventHandlers;
        public override void OnEnable()
        {
            if (!Config.GetBool("cbadges_enabled", true)) return;
            badges = Config.GetStringDictionary("cbadges_badges");
            users = Config.GetStringDictionary("cbadges_users");

            EventHandlers = new EventHandlers(this);

            // Event registration
            Events.PlayerJoinEvent += EventHandlers.OnPlayerJoin;
        }

        public override void OnDisable()
        {
            EventHandlers = null;

            //Event unregistration
            Events.PlayerJoinEvent -= EventHandlers.OnPlayerJoin;
        }

        public override void OnReload(){}

        public override string getName => "CustomBadges (https://discord.gg/CfrQHuB)";
    }
}
