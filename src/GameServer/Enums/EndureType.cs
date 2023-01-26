using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EndureType
    {
        NONE,
        DEFAULT,
        AVATAR_SWORD,
        AVATAR_POLE,
        AVATAR_CLAYMORE,
        AVATAR_BOW,
        AVATAR_CATALYST,
        MONSTER_MINION,
        MONSTER_GRUNT_HUMANOID,
        MONSTER_GRUNT_OTHER,
        MONSTER_DEMIBOSS_HUMANOID,
        MONSTER_DEMIBOSS_OTHER,
        MONSTER_BOSS_HUMANOID,
        MONSTER_BOSS_OTHER,
        MONSTER_SLIME,
        MONSTER_TARTAGLIA,
    }
}
