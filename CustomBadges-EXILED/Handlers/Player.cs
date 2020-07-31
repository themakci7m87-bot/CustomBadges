namespace CustomBadges.Handlers
{
    using System.Collections.Generic;

    using Exiled.Events.EventArgs;

    internal sealed class Player
    {
        public Dictionary<string, List<string>> Badges;

        internal void OnJoined(JoinedEventArgs ev)
        {
            if (!string.IsNullOrEmpty(ev.Player.RankName) ||
                !Badges.ContainsKey(ev.Player.UserId)) return;

            #region Issuing a custom badge
            List<string> rank = Badges[ev.Player.UserId];

            ev.Player.RankName = rank[0];
            ev.Player.RankColor = rank[1];
            ev.Player.BadgeHidden = true;
            #endregion
        }
    }
}
