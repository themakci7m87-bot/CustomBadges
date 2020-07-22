namespace CustomBadges
{
    using System.Collections.Generic;
    using System.ComponentModel;

    using Exiled.API.Interfaces;

    public sealed class Config : IConfig
    {
        [Description("Indicates whether the plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Dictionary containing player badges")]
        public static Dictionary<string, List<string>> Badges { get; private set; } = new Dictionary<string, List<string>>();
    }
}
