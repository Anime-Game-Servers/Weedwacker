using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByItemNumber : ConfigAbilityPredicate
{
	public uint itemId;
	public uint itemNum;
}
