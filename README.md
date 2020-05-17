# CustomBadges
Exiled plugin for creating custom badges
## Installation
1. Move `CustomBadges.dll` to `~/.config/Plugins` (`%appdata%\Plugins` on Windows)
1. Change the configuration file (`~/.config/EXILED/<port>-config.yml` (`%appdata%\EXILED\<port>-config.yml` on Windows)) according to the following section
## Configuration
| Key             | Type              | Def. Vault |
|-----------------|-------------------|------------|
| cbadges_enabled | bool              | true       |
| cbadges_badges  | String Dictionary |            |
| cbadges_users   | String Dictionary |            |
#### Example
```yaml
cbadges_enabled: true
cbadges_badges:
 - Apple: red

cbadges_users:
 - 76561198907264325@steam: Apple
```
