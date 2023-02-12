using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TornadoMixin : ConfigAbilityMixin
{
	public ConfigTornadoZone[] stageZone;
	public ConfigAbilityPredicate[] predicates;
	public TargetType targetType;
	public ConfigBornType born;
	public object enviroWindStrength;
	public object enviroWindRadius;
}
