namespace CustomBadges.Handlers
{
    using System.Collections.Generic;

    using Exiled.Events.EventArgs;

    internal sealed class Player
    {
        internal void OnJoined(JoinedEventArgs ev)
        {
            if (Config.Badges.ContainsKey(ev.Player.UserId))
            {
                List<string> rank = Config.Badges[ev.Player.UserId];
                ev.Player.RankName = rank[1];
                ev.Player.RankColor = rank[2];
            }
        }
    }
}
