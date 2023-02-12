using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TDPlayMixin : ConfigAbilityMixin
{
	public TDPlayTowerType towerType;
	public float baseCD;
	public float baseAttackRange;
	public ConfigAbilityAction[] onFireActions;
	public string towerModifierName;
	public uint[] bulletIDs;
	public ConfigBornType born;
	public string[] partRootNames;
	public ControlPartTargetType targetType;
}
