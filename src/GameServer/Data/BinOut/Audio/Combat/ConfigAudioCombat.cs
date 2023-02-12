using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioCombat
{
	public AudioOneTimeEvent impactEvent;
	public AudioOneTimeEvent arrowImpactHeadEvent;
	public AudioOneTimeEvent bushImpactEvent;
	public AudioOneTimeEvent treeImpactEvent;
	public ConfigWwiseString putAwayWeaponEvent;
	public ConfigWwiseString strikeTypeSwitchKey;
	public Dictionary<StrikeType, ConfigWwiseString> strikeTypeSwitchMap;
	public ConfigWwiseString strikeTypeSwitchDefault;
	public ConfigWwiseString elementTypeSwitchKey;
	public Dictionary<ElementType, ConfigWwiseString> elementTypeSwitchMap;
	public ConfigWwiseString elementTypeSwitchDefault;
	public AudioOneTimeEvent hitSceneEvent;
	public ConfigWwiseString whetherRecurringSwitchKey;
	public ConfigWwiseString hitOneshotSwitchValue;
	public ConfigWwiseString hitRecurringSwitchValue;
	public ConfigWwiseString entityFadeOutEvent;
	public ConfigWwiseString patrollerTemperatureRtpc;
	public ConfigWwiseString patrollerAwareEvent;
	public ConfigWwiseString patrollerAlertEvent;
	public ConfigWwiseString patrollerCalmEvent;
	public AudioImpactOverrideEvent[] impactOverrideEvents;
	public AudioImpactOverrideEvent[] arrowImpactOverrideEvents;
	public uint[] hittingSceneIgnoreList;
	public ConfigWwiseString isMostDangerousRtpcKey;
	public ConfigWwiseString isEndingHitRtpcKey;
	public ConfigWwiseString cirtDamageRateRtpcKey;

	public class AudioImpactOverrideEvent
	{
		public uint entityId;
		public AudioOneTimeEvent impactEvent;
	}
}