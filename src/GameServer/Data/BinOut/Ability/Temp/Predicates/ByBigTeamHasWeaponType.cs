using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByBigTeamHasWeaponType : ConfigAbilityPredicate
{
	public string weaponType;
	public uint number;
	public RelationalOperator logic;
}