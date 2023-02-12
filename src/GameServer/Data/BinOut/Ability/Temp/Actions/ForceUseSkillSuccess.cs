using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ForceUseSkillSuccess : ConfigAbilityAction
{
	public uint skillID;
	public UseSkillType type;
	public bool immediately;
}
