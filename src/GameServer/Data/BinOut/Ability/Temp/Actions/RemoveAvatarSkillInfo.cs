using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class RemoveAvatarSkillInfo : ConfigAbilityAction
{
	public uint skillID;
	public bool refreshAfterRemove;
}
