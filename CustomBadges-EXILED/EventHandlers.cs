using EXILED;
using EXILED.Extensions;
using EXILED.Patches;
using System.Collections.Generic;

namespace CustomBadges
{
    public class EventHandlers
    {
        private Plugin Plugin;

        public EventHandlers(Plugin plugin) => Plugin = plugin;

        // Event Handlers

        internal void OnPlayerJoin(EXILED.PlayerJoinEvent ev)
        {
            // Main code
            foreach (KeyValuePair<string, string> user in Plugin.users)
            {
                if(ev.Player.GetUserId() == user.Key)
                {
                    foreach (KeyValuePair<string, string> badge in Plugin.badges)
                    {
                        if(user.Value == badge.Key)
                        {
                            ev.Player.SetRank(badge.Key, badge.Value, true);
                        }
                    }
                }
            }
        }
    }
}
