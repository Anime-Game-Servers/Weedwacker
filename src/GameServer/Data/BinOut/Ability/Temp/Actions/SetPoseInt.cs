using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetPoseInt : ConfigAbilityAction
{
	public string intID;
	public int value;
}
