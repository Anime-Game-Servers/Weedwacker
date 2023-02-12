using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioUi
{
	public AudioUiSupport support;
	public AudioUiEquip equip;
	public ConfigWwiseString openChestEvent;
	public AudioOneTimeEvent joinTeamEvent;
	public ConfigWwiseString elementStateKey;
	public ConfigWwiseString elementStateDefaultValue;
	public Dictionary<string, string> elementStateValueMap;
	public ConfigWwiseString characterAppearEvent;
	public ConfigWwiseString addMapPinEvent;
	public ConfigWwiseString removeMapPinEvent;
	public ConfigWwiseString enableElementViewEvent;
	public ConfigWwiseString disableElementViewEvent;
	public ConfigWwiseString dungeonVictoryEvent;
	public ConfigWwiseString dungeonDefeatEvent;
	public ConfigWwiseString changeWeaponEvent;
	public ConfigWwiseString wearRelicEvent;
	public ConfigWwiseString takeoffRelicEvent;
	public ConfigWwiseString selectAvatarRelicEvent;
	public ConfigWwiseString addEquipMaterialEvent;
	public ConfigWwiseString talentUnlockEvent;
	public ConfigWwiseString changeAvatarSuccessEvent;
	public ConfigWwiseString changeAvatarFailedEvent;
	public ConfigWwiseString selectMainQuestEvent;
	public ConfigWwiseString teamAvatarHoldUp;
	public ConfigWwiseString teamAvatarHoldDown;
	public ConfigWwiseString teamAvatarClick;
	public ConfigWwiseString bagDropItem;
	public ConfigWwiseString mailDeleteEvent;
	public ConfigWwiseString itemInCDEvent;
	public ConfigWwiseString pickUpEvent;
	public ConfigWwiseString playerLevelBtnEvent;
	public ConfigWwiseString chestPickupFailEvent;
	public ConfigWwiseString enterDungeonSuccessEvent;
	public ConfigWwiseString openPageDefaultEvent;
	public ConfigWwiseString closePageDefaultEvent;
	public Dictionary<string, ConfigWwiseString> openPageCustomEvents;
	public Dictionary<string, ConfigWwiseString> closePageCustomEvents;
	public ConfigWwiseString videoStartDefaultEvent;
	public ConfigWwiseString videoEndDefaultEvent;
	public Dictionary<string, ConfigWwiseString> videoStartCustomEvents;
	public Dictionary<string, ConfigWwiseString> videoEndCustomEvents;
	public int defaultEnableDelayCount;
	public ConfigWwiseString characterSelectMusicEndEvent;
	public Dictionary<int, ConfigWwiseString> loadingEventsMap;

	public class AudioUiSupport
	{
		public ConfigWwiseString comboRtpcKey;
		public float countdown;
	}
	public class AudioUiEquip
	{
		public ConfigWwiseString equipOnEvent;
	}
}