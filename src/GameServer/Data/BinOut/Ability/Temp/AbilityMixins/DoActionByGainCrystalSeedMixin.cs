using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByGainCrystalSeedMixin : ConfigAbilityMixin
{
	public ElementType[] elementTypes;
	public ConfigAbilityAction[] actions;
}
