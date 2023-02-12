using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class EquipAffixStart : ConfigAbilityAction
{
	public object CD;
	public uint equipAffixDataID;
}
