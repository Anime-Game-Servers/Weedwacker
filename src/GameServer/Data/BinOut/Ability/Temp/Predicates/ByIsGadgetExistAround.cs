using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByIsGadgetExistAround : ConfigAbilityPredicate
{
	public uint[] gadgetIdArray;
	public bool trunToTarget;
}
