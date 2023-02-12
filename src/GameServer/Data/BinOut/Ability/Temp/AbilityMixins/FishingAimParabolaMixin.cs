using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class FishingAimParabolaMixin : ConfigAbilityMixin
{
	public float minAngle;
	public float maxAngle;
	public float minRange;
	public float maxRange;
	public string globalValueKey;
	public SelectTargets otherTargets;
	public AbilityTargetting target;
}
