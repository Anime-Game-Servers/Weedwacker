using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ModifyAvatarSkillCD : ConfigAbilityAction
{
	public uint skillID;
	public uint[] skillSlot;
	public object cdDelta;
	public object cdRatio;
}
