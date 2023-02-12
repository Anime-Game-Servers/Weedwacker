using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class CollisionMixin : ConfigAbilityMixin
{
	public ConfigCollision collision;
	public float minShockSpeed;
	public float cd;
	public ConfigAbilityAction[] onCollision;
}
