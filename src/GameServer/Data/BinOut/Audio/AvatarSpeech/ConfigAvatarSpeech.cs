using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAvatarSpeech
{
	public AvatarSpeechEquipObtain[] suitableEquipObtain;
	public AvatarSpeechEquipObtain[] unsuitableEquipObtain;
	public string eventCommonPrefix;
	public ConfigWwiseString externalVoiceEvent;
	public ConfigWwiseString personSwitchKey;
	public ConfigWwiseString positioningSwitchKey;
	public ConfigWwiseString initialDelayRTPC;
	public Dictionary<string, string> personSwitchValueMap;
	public Dictionary<string, string> positioningSwitchValueMap;
	public VoiceSound[] externalSoundNames;
	public float defaultNarrationInterval;
	public float defaultNarrationDuration;
	public float defaultNarrationMaxDuration;
	public uint gachaVoiceTriggerParam;
	public uint joinTeamVoiceTriggerParam;
	public Dictionary<uint, VoiceTriggerIdentity> fetterVoiceTriggerMap;
	public float teammateLowHPVo_hpRatio;
	public uint teammateLowHPVo_cooldown;
	public VoiceTriggerIdentity teammateLowHPVo_voTrigger;
	public float teammateLowHPVo_distance;
	public float teammateLowHPVo_hpDescRatio;
	public Dictionary<uint, float> teammateLowHPVo_distanceMap;
	public float localPlayerLowHPVo_hpRatio;
	public uint localPlayerLowHPVo_cooldown;
	public VoiceTriggerIdentity localPlayerLowHPVo_voTrigger;
	public Dictionary<uint, VoiceTriggerIdentity> promotionVoiceTriggerMap;
	public VoiceTriggerIdentity openChestVoTrigger;
	public string[] voiceBlackList;

	public class AvatarSpeechEquipObtain
	{
		public int quality;
		public ConfigWwiseString eventName;
	}
	public class VoiceSound
	{
		public VoicePersonality personality;
		public VoicePositioning positioning;
		public ConfigWwiseString soundName;
	}
}