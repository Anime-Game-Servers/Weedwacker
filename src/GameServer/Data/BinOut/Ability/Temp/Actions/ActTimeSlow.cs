using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ActTimeSlow : ConfigAbilityAction
{
	public ConfigTimeSlow timeSlow;
	public bool isGlobal;

	public class ConfigTimeSlow
	{
		public float duration;
		public float slowRatio;
	}
}
