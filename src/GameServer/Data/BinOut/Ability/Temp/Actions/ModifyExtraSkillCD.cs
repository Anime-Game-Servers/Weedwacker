
namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ModifyExtraSkillCD : ConfigAbilityAction
{
	public uint skillID;
	public object cdDelta;
	public object cdRatio;
	public object cdMin;
}