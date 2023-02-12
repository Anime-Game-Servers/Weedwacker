using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class BoxClampWindZoneMixin : ConfigAbilityMixin
{
	public Vector size;
	public ConfigBornType born;
	public float attracForceStrength;
	public float maxStrengthRange;
}
