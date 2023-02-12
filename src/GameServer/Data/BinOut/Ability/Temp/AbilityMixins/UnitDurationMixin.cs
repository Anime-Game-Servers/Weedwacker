using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class UnitDurationMixin : ConfigAbilityMixin
{
	public bool isTrigger;
	public string[] modifierName;
	public object[] steps;
}
