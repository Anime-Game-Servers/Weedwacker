using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class OverrideHitImpulseMixin : ConfigAbilityMixin
{
	public Dictionary<string, overrideHitImpulse> overrideHitImpulseMap;

	public class overrideHitImpulse
	{
		public string hitLevel;
		public float hitImpulseX;
		public float hitImpulseY;
	}
}
