using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class AbilityOverrideExcelConfig
{
	public uint id;
	public string abilityName;
	public AbilityOverrideParamConfig[] abilitySpecialParamConfig;
	public string[] paramNameList;
	public float[] paramValueList;
	public bool resetAbilitySpecial;

	public class AbilityOverrideParamConfig
	{
		public string paramName;
		public float paramValue;
	}
}