using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioSetting
{
	public AudioSettingSlider_PostEvent globalVolume;
	public AudioSettingSlider_PostEvent sfxVolume;
	public AudioSettingSlider_PostEvent musicVolume;
	public AudioSettingSlider_PostVoice voiceVolume;
	public VibrationSetting vibration;
	public ConfigWwiseString dualSenseRTPC;
	public ConfigWwiseString dynamicRangeRTPCKey;
	public Dictionary<int, OutputSetting> outputSettingMap;
	public Dictionary<string, AudioPlatformSetting> platformSettings;

	public class AudioPlatformSetting
	{
		public AudioRequirement[][] audioAPIDefaultOpenSL_ESRequirements;

		public class AudioRequirement
		{
			public string Info;
			public string[] Values;
		}
	}
	public class VibrationSetting
	{
		public ConfigWwiseString rtpc;
		public float openValue;
		public float closeValue;
	}
	public class OutputSetting
	{
		public string name;
		public ConfigWwiseString bus;
		public uint channelMask;
		public BusChannelConfig[] busChannelConfigList;

		public class BusChannelConfig
		{
			public ConfigWwiseString bus;
			public uint channelMask;
		}
	}
}