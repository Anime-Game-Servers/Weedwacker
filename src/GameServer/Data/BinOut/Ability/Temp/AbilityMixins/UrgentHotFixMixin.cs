using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class UrgentHotFixMixin : ConfigAbilityMixin
{
	public uint logicId;
	public float thinkInterval;
	public ConfigAbilityAction[] actionList;
}