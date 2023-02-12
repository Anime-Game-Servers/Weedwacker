using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ModifyVehicleSkillCD : ConfigAbilityAction
{
	public uint skillID;
	public object cdDelta;
	public object cdRatio;
}
