using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetAnimatorFloat : ConfigAbilityAction
{
	public string floatID;
	public object value;
	public bool persistent;
	public bool useRandomValue;
	public object randomValueMin;
	public object randomValueMax;
	public float transitionTime;
}
