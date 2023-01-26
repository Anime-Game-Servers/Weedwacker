using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConfigAbilitySubContainerType : uint
    {
        NONE,
        ACTION,
        MIXIN,
        MODIFIER_ACTION,
        MODIFIER_MIXIN
    }
}
