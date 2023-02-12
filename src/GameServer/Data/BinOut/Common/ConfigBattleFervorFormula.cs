using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBattleFervorFormula
{
	public ConfigBattleFervorGroup[] groups;
	public float battleFervorMinValue;
	public float battleFervorMaxValue;
	public float battleFervorBaseValue;
	public float lerpInterval;
	public float lerpCoefficient;

	public class ConfigBattleFervorGroup
	{
		public float weight;
		public ConfigBattleFervorFactor[] factors;
	}
}