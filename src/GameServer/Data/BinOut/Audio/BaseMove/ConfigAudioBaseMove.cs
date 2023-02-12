using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioBaseMove
{
	public ConfigWwiseString moveRtpcKey;
	public AudioPlatformMoveSettings[] platformSettings;
	public AudioPlatformMoveSettingsUsagePair[] platformSettingUsageMapping;

	public class AudioPlatformMoveSettings
	{
		public uint id;
		public AudioPlatformMoveType moveType;
		public ConfigWwiseString moveStartEvent;
		public ConfigWwiseString moveStopEvent;
		public ConfigWwiseString rotateStartEvent;
		public ConfigWwiseString rotateStopEvent;
		public float linearVelocityThreshold;
		public float angularVelocityThreshold;
	}
	public class AudioPlatformMoveSettingsUsagePair
	{
		public uint entityId;
		public uint settingsId;
	}
}