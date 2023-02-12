using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigClimate
{
	public ConfigClimateCommon common;
	public Dictionary<string, ConfigClimateInfoBase> templates;

	public class ConfigClimateCommon
	{
		public float length;
		public float thresholdRatio;
		public Dictionary<JsonClimateType, uint[]> debuffs;
		public Dictionary<JsonClimateType, uint[]> areaBuffs;
		public ConfigClimateMisc miscs;
		public ConfigClimatePerform perform;
		public float uiWarningRatio;
		public float uiLenWeakIntensity;
		public float uiLenLerpSpeed;

		public class ConfigClimateMisc
		{
			public float dampingTime;
			public float fadeSpeed;
		}
		public class ConfigClimatePerform
		{
			public float chance;
			public Dictionary<JsonClimateType, string> performTriggers;
		}
	}
}