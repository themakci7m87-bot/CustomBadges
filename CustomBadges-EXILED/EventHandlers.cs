namespace CustomBadges
{
    using System.Collections.Generic;

    using Exiled.Events.EventArgs;

    internal sealed class EventHandlers
    {
        public Dictionary<string, List<string>> Badges;

        internal void OnJoined(JoinedEventArgs ev)
        {
            if (!Badges.ContainsKey(ev.Player.UserId)) return;

            List<string> rank = Badges[ev.Player.UserId];
            if (!string.IsNullOrEmpty(ev.Player.RankName))
            {
                ev.Player.RankName += $" | {rank[0]}";
                ev.Player.RankColor = rank[1];
                return;
            }
            #region else
            ev.Player.RankName = rank[0];
            ev.Player.RankColor = rank[1];
            ev.Player.BadgeHidden = false;
            #endregion
        }

        internal void OnSendingConsoleCommand(SendingConsoleCommandEventArgs ev)
        {
            if (!Badges.ContainsKey(ev.Player.UserId)) return;
            switch (ev.Name.ToLower())
            {
                default:
                    return;
                case "hidetag":
                    if (ev.Player.BadgeHidden) return;
                    ev.Player.BadgeHidden = true;
                    return;
                case "showtag":
                    if (!ev.Player.BadgeHidden) return;
                    ev.Player.BadgeHidden = false;
                    return;
            }
        }
    }
}
