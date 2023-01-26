using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CombatPropertyIndex
    {
        hp,
        attack,
        defense,
        weight,
        endure,
        level,
        elementaddhurt,
        defenseignore
    }
}
