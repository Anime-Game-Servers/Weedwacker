using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGlobalCombat
{
	public ConfigCommonHitData hitData;
	public ConfigGlobalCollision collisionData;
	public ConfigGlobalAI aiData;
	public ConfigGlobalMove moveData;
	public ConfigAvatarHitBucketSetting defaultAvatarHitBucketSetting;
	public Dictionary<string, ConfigBladeElementFx> elementBladeData;
	public ConfigFireGrassAirflowField fireGrassAirflowData;
	public ConfigGloablMiscs miscs;
	public ConfigDefaultAbilities defaultAbilities;
	public Dictionary<string, Dictionary<string, float>> elemReactDamage;
	public Dictionary<string, Dictionary<string, float>> elemAmplifyDamage;
	public ElementType[] elemPrority;
	public ConfigGlobalShakeOff shakeOff;
	public ConfigElementShield elementShield;
	public ConfigEliteShield eliteShield;
	public ConfigGlobalSwitch globalSwitch;
	public ConfigGlobalLockTarget lockTarget;
	public ConfigElementUI elemUI;
	public Dictionary<AbilityState, ElementReactionType[]> rejectElementReaction;
	public ConfigLogSetting logSetting;
	public Dictionary<string, ConfigAttackAttenuation> attackAttenuation;
	public ConfigGadgetCreationLimit[] gadgetCreationLimits;
	public ConfigLuaSafetyCheckSwitch luaSafetySwitch;
	public Dictionary<int, float> tempComponentBudget;
	public ConfigGlobalInteraction globalInteraction;
	public Vector[] lampOffset;
	public Dictionary<AbilityState, string> abilityStateTriggerAbilities;
	public ConfigGlobalDither dither;
	public Dictionary<string, ConfigElementDecrate[]> elementDecrateGroup;
	public ConfigSliceFrameWatch sliceFrameWatch;
	public ConfigIK ik;
	public Dictionary<int, EquipSizeData[]> avatarEquipSizeDatas;
	public Dictionary<int, EquipSizeData[]> manekinEquipSizeDatas;
	public ConfigBigWorldEnvironmentDamageClamp bigWorldEnvironmentDamageClamp;
	public ConfigTDPlay tdPlay;
	public ConfigSafeTypeReportData gameAnimSafeType;
	public Dictionary<string, ElementConvertToChargeBarValueMixinItem[]> elementConvertToChargeBarValueMixinItemGroup;
	public string chargeBarMixinGlobalValueKey;
	public ConfigElementReactionCoefficients elementReactionCoefficients;
	public ConfigBattleFervorFormula battleFervorFormula;
	public Dictionary<string, ConfigCombat> combatTemplate;
	public string[] combatAntiCheatAttackTagWhiteList;
	public ConfigCommonVisualDieData dieData;

	public class ConfigCommonVisualDieData
	{
		//speculated types
		public float dieEndTime;
		public float dieEndMaxTime;
	}
	public class EquipSizeData
	{
		public EquipEntityType equipType;
		public float putAwaySize;
		public float takeOutSize;
	}
	public class ConfigBigWorldEnvironmentDamageClamp
	{
		public int reduceLevel;
		public int worldLevelCutThreshhold;
	}
	public class ConfigTDPlay
	{
		public float attackSpeed_C;
		public Dictionary<TDPlayTowerType, ConfigTDPlayTowerData> towerDatas;
		public class ConfigTDPlayTowerData
		{
			public TDPlayTowerType towerType;
			public float damagePerLevel;
			public float elemMasteryPerLevel;
			public float elemMasteryPerPerStack;
			public float damage_A_PerStack;
			public float damage_B_PerStack;
			public float attackSpeed_A;
			public float attackSpeed_B;
			public float attackRange_A;
			public float attackRange_B;
		}
	}
	public class ConfigSafeTypeReportData
	{
		public int maxCount;
	}
	public class ElementConvertToChargeBarValueMixinItem
	{
		public ElementType elementType;
		public float ratio;
	}
	public class ConfigElementReactionCoefficients
	{
		public float coefficientOverdose;
	}
	public class ConfigIK
	{
		public ConfigBoolForPlatforms remoteMoveIK;
		public ConfigBoolForPlatforms remoteClimbIK;

		public class ConfigBoolForPlatforms
		{
			public bool ps4;
			public bool android;
			public bool ios;
			public bool pc;
			public bool editor;
		}
	}
	public class ConfigSliceFrameWatch
	{
		public float amortizedTickMassiveEntityBudget;
		public float sharedSliceFrameGameSystemTime;
		public float resourcesManagerAssetJobMinTime;
		public float resourcesManagerAssetJobMaxTime;
		public float resourcesManagerInstantiateMinTime;
		public float resourcesManagerInstantiateMaxTime;
		public float resourcesManagerUnloadMinTime;
		public float resourcesManagerUnloadMaxTime;
		public float resourcesManagerInstantiateJobTime;
		public float levelAppearDisappearTimeMSDefault;
		public int levelAppearDisappearWRRWeight;
		public float InitComponentCommonSlicingTimeDefault;
		public float removeEntityTimeMSDefault;
		public int removeEnityWRRWeight;
		public int sectrWRRWeightDefault;
		public float timerManagerTimeMS;
		public bool UseLegacyGenericObjectPool;
		public int significanceTaskThreadLOD;
		public bool loadingUseSyncLoad;
	}
	public class ConfigElementDecrate
	{
		public ElementType elem1;
		public ElementType elem2;
		public float ratio;
	}
	public class ConfigLuaSafetyCheckSwitch
	{
		public bool tickWorld;
		public uint tickWorldCD;
		public bool tickChest;
		public bool tickMonster;
	}
	public class ConfigGadgetCreationLimit
	{
		public string tag;
		public uint[] gadgetIDs;
		public uint maxValue;
	}
	public class ConfigDefaultAbilities
	{
		public string monterEliteAbilityName;
		public string[] nonHumanoidMoveAbilities;
		public string[] levelDefaultAbilities;
		public string[] levelElementAbilities;
		public string[] levelItemAbilities;
		public string[] levelSBuffAbilities;
		public string[] dungeonAbilities;
		public string[] defaultTeamAbilities;
		public string[] defaultMPLevelAbilities;
		public string[] defaultAvatarAbilities;
	}
	public class ConfigElementShield
	{
		public ElementType[] row;
		public Dictionary<ElementType, ConfigElementShieldResistance> shieldDamageRatiosMap;
		public class ConfigElementShieldResistance
		{
			public ElementType elementType;
			public float[] damageRatio;
			public int[] restraint;
		}
	}
	public class ConfigEliteShield
	{
		public ElementType[] row;
		public Dictionary<string, ConfigEliteShieldResistance> shieldDamageRatiosMap;
		public class ConfigEliteShieldResistance
		{
			public string type;
			public float[] damageRatio;
			public float[] damageSufferRatio;
		}
	}
	public class ConfigElementUI
	{
		public EntityType[] showIconEntityTypes;
		public EntityType[] showReactionEntityTypes;
		public float iconRecoverTime;
		public float iconDisappearTime;
		public uint iconDisappearRound;
		public float iconShowDistance;
		public Dictionary<string, string> overrideElemPath;
		public Dictionary<ElementReactionType, string> reactionElemPath;
	}
	public class ConfigLogSetting
	{
		public bool sendEngineLogToServer;
	}
	public class ConfigAttackAttenuation
	{
		public float resetCycle;
		public float[] durabilitySequence;
		public float[] enbreakSequence;
		public float[] damageSequence;
	}
}