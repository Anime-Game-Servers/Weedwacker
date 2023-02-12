using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetPoseFloat : ConfigAbilityAction
{
	public string floatID;
	public object value;
}
