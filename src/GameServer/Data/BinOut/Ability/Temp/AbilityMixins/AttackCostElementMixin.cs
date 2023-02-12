using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttackCostElementMixin : ConfigAbilityMixin
{
	public StrikeType strikeType;
	public ElementType elementType;
	public AttackType attackType;
	public float strikeCostRatio;
	public float attackCostRatio;
	public float elementCostRatio;
	public ElementType costElementType;
	public AttackCostType costType;
}
