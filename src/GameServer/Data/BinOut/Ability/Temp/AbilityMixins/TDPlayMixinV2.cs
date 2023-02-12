using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TDPlayMixinV2 : ConfigAbilityMixin
{
	public TDPlayTowerType towerType;
	public float baseCD;
	public float baseAttackRange;
	public ConfigAbilityAction[] onFireActions;
	public uint bulletID;
	public ConfigBornType born;
	public string[] partRootNames;
	public ControlPartTargetType targetType;
}
