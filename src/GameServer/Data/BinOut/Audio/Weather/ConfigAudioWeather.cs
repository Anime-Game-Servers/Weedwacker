using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioWeather
{
	public ConfigWwiseString transitionRtpcKey;
	public ConfigWwiseString dominantStateName;
	public ConfigWwiseString dominantSwitchName;
	public ConfigWwiseString dominantRtpcKey;
	public ConfigWwiseString dominantStateNameWithoutDelay;
	public ConfigWwiseString dominantRtpcKeyWithoutDelay;
	public ConfigWwiseString timeOfDayRtpcKey;
	public ConfigWwiseString avatarSpeechEvent;
	public Dictionary<string, AudioWeatherProperties> weatherStateMap;
	public AudioWeatherWorkSet workset1;
	public AudioWeatherWorkSet workset2;
	public AudioOneTimeEvent nearThunderStart;
	public AudioOneTimeEvent nearThunderEnd;
	public AudioOneTimeEvent distantThunderStart;
	public AudioOneTimeEvent distantThunderEnd;
	public AudioOneTimeEvent skyThunder;
	public ConfigWwiseString worksetSwitchKey;
	public ConfigWwiseString windSpeedRtpcKey;
	public ConfigWwiseString windDirectionRtpcKey;
	public ConfigWwiseString climateRtpcKey;
	public Dictionary<string, string> climateRTPCMap;
	public AudioWeatherVoTrigger[] weatherVoiceTriggers;
	public VoiceTriggerIdentity thunderVoiceTrigger;
	public uint thunderVoiceCooldown;
	public ConfigWwiseString enviroTimeRtpcKey;
	public ConfigWwiseString angleBetweenWindAndListenerRtpcKey;
	public float angleStaticUpdateRate;
	public float angleDynamicUpdateRate;

	public class AudioWeatherProperties
	{
		public ConfigWwiseString stateValue;
		public ConfigWwiseString musicStateValue;
		public ConfigWwiseString switchValue;
		public float rtpcValue;
		public string surfaceOverride;
	}
	public class AudioWeatherWorkSet
	{
		public ConfigWwiseString stateGroupName;
		public ConfigWwiseString activenessRtpcName;
		public ConfigWwiseString worksetSwitchValue;
	}
	public class AudioWeatherVoTrigger
	{
		public ConfigWeatherType[] weatherTypeList;
		public bool weatherTypeIsInclude;
		public string[] weatherList;
		public bool weatherIsInclude;
		public ConfigWeatherType[] previousWeatherTypeList;
		public bool previousWeatherTypeIsInclude;
		public string[] previousWeatherList;
		public bool previousWeatherIsInclude;
		public VoiceTriggerIdentity voTrigger;
		public AudioWeatherVoTrigger_TimeRule[] timeLimit;

		public class AudioWeatherVoTrigger_TimeRule
		{
			public float from;
			public float to;
		}
	}
}