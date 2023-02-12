using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AvatarSkillStart : ConfigAbilityAction
{
	public uint skillID;
	public object cdRatio;
	public object costStaminaRatio;
}
