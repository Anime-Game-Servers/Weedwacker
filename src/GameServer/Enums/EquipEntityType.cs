using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EquipEntityType
    {
        None,
        SwordOneHand,
        CrossBow,
        SmallShield,
        Spear,
        Catalyst,
        Bow,
        Claymore,
        Pole
    }
}
