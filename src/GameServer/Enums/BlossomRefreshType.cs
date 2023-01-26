using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BlossomRefreshType
    {
        BLOSSOM_REFRESH_NONE,
        BLOSSOM_REFRESH_SCOIN,
        BLOSSOM_REFRESH_WEAPON,
        BLOSSOM_REFRESH_EXP,
        BLOSSOM_REFRESH_CRYSTAL,
        BLOSSOM_REFRESH_INFUSED_CRYSTAL,
        BLOSSOM_REFRESH_DRAGON_SPINE_A,
        BLOSSOM_REFRESH_DRAGON_SPINE_B,
        BLOSSOM_ISLAND_SENTRY_TOWER_A,
        BLOSSOM_ISLAND_SENTRY_TOWER_B,
        BLOSSOM_ISLAND_BOMB,
        BLOSSOM_REFRESH_BLITZ_RUSH_A,
        BLOSSOM_REFRESH_BLITZ_RUSH_B,
    }
}
