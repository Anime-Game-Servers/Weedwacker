using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigPlatformMove : ConfigMove
{
	public float AvatarTriggerEventDistance;
	public bool IsMovingWater;
	public bool calcMoveStateInTick;
	public ConfigRoute route;
	public MovePlatformDelayType delayType;
}
