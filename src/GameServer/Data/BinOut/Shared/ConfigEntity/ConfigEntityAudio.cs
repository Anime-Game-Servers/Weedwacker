using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigEntityAudio
{
	public ConfigAnimationAudio animAudio;
	public ConfigWwiseString initEvent;
	public ConfigWwiseString enableEvent;
	public ConfigWwiseString disableEvent;
	public ConfigWwiseString destroyEvent;

	public class ConfigAnimationAudio
	{
		public ConfigStateAudioEvent[] onTransitionIn;
		public ConfigStateAudioEvent[] onTransitionOut;
		public Dictionary<string, ConfigAnimationRecurrentSpeech> recurrentSpeeches;

		public class ConfigAnimationRecurrentSpeech
		{
			public ConfigFluctuatedValue start;
			public ConfigFluctuatedValue interval;
			public ConfigWwiseString eventName;

			public class ConfigFluctuatedValue
			{
				public float upper;
				public float lower;
			}
		}
	}
}