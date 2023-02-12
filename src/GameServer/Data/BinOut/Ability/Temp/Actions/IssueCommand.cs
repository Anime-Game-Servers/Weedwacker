using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class IssueCommand : ConfigAbilityAction
{
	public int commandID;
	public float duration;
}
