using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class BySkillReady : ConfigAbilityPredicate
{
	public uint skillID;
	public uint[] skillSlot;
}
