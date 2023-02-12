using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class EntityDitherMixin : ConfigAbilityMixin
{
	public ConfigAbilityPredicate[] predicates;
	public float ditherValue;
	public float cutInTime;
	public float cutOutTime;
	public bool forceUpdateAtStart;
}
