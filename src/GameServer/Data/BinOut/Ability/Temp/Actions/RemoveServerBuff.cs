using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class RemoveServerBuff : ConfigAbilityAction
{
	public uint sBuffId;
	public bool isTeamBuff;
}
