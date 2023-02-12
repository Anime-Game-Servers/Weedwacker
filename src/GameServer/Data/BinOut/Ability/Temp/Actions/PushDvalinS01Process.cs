using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class PushDvalinS01Process : ConfigAbilityAction
{
	public float time;
	public float toPercentage;
	public bool unBreak;
	public bool setForce;
	public Vector vector;
	public float attenuation;
}
