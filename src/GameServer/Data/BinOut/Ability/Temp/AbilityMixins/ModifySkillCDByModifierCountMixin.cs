using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ModifySkillCDByModifierCountMixin : ConfigAbilityMixin
{
	public TargetType targetType;
	public string modifierName;
	public uint skillID;
	public object cdDelta;
}
