namespace CustomBadges.Handlers
{
    using System.Collections.Generic;

    using Exiled.Events.EventArgs;

    internal sealed class Player
    {
        private static Config Config;

        private void SetRank(Exiled.API.Features.Player player, string RankName, string RankColor, bool show)
        {
            player.RankName = RankName;
            player.RankColor = RankColor;
            player.BadgeHidden = !show;
        }

        internal void OnJoined(JoinedEventArgs ev)
        {
            
            if (!string.IsNullOrEmpty(ev.Player.RankName)) return;
            else if (!Config.Badges.ContainsKey(ev.Player.UserId)) return;

            // Issuing a custom badge
            {
                List<string> rank = Config.Badges[ev.Player.UserId];

                SetRank(ev.Player, rank[1], rank[2], true);
            }
        }
    }
}
