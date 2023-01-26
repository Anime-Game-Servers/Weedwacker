using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TriggerFlag
    {
        None,
        NoReviveRegion,
        DeadRegion,
        ReturnRegion,
        CameraSceneLook,
        LevelAbility,
        AudioEvent,
        GlobalValue,
        Teleport
    }
}
