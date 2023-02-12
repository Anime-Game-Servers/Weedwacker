using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ModifyCameraMaxDistanceMixin : ConfigAbilityMixin
{
	public float MaxDistance;
	public bool ResetToMaxOnStart;
	public float LerpInDuration;
	public float LerpOutDuration;
}
