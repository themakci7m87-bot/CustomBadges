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
        public Dictionary<string, List<string>> Badges { get; private set; } = new Dictionary<string, List<string>>() 
        {
            {
                "76561198907264325@steam", new List<string>
                {
                    "Pepe", "green"
                }
            }
        };
    }
}
