using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetSkillPoint : ConfigAbilityPredicate
{
	public uint skillID;
	public object value;
	public RelationType compareType;
}