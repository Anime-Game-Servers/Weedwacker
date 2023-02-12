using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetAISkillCDAvailableNow : ConfigAbilityAction
{
	public uint[] skillIDs;
}
