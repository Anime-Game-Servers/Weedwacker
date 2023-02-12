using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class VelocityDetectMixin : ConfigAbilityMixin
{
	public float minSpeed;
	public float maxSpeed;
	public bool detectOnStart;
	public ConfigAbilityAction[] onPoseedge;
	public ConfigAbilityAction[] onNegedge;
}
