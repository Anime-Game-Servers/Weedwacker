using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigClimateInfo : ConfigClimateInfoBase
{
	public JsonClimateType climateType;
	public ConfigClimateTemperatureOptions temperatureOptions;
	public ConfigClimateUI climateUIInfo;
	public ConfigClimateAudio climateScreenEffAudio;

	public class ConfigClimateTemperatureOptions
	{
		public float speed;
	}
	public class ConfigClimateUI
	{
		public string climateInfoBtnIcon;
		public string climateDialogTitle;
		public string climateDialogDesc;
		public string climateDialogLeftIcon;
		public string climateDialogLeftBg;
		public bool showClimateMeter;
		public uint climateMeterColorIndex;
		public uint climateMeterBgColorIndex;
		public uint screenEffectIndex;
		public bool climateInfoShowWithMeterType;
		public float uiLowWarningRatio;
		public float uiLenLowIntensity;
		public float uiMiddleWarningRatio;
		public float uiLenMiddleIntensity;
	}
	public class ConfigClimateAudio
	{
		public string uiLenStopAudio;
		public string uiLenLowAudio;
		public string uiLenMiddleAudio;
		public string uiLenMaxAudio;
	}
}