using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ReTriggerAISkillInitialCD : ConfigAbilityAction
{
	public uint[] skillIDs;
	public bool forceReinit;
}
