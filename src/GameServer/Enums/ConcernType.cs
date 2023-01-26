using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConcernType
    {
        AllExcludeGwgo,
        CombatExcludeGwgo,
        AllAvatars,
        LocalAvatar,
        LocalTeam,
        AllVehicle,
        AllAvatarsOnVehicle,
        LocalVehicle
    }
}
