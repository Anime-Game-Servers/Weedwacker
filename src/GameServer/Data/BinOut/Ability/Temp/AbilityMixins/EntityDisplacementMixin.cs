using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class EntityDisplacementMixin : ConfigAbilityMixin
{
	public float triggerDistance;
	public ConfigAbilityAction[] actionList;
}
