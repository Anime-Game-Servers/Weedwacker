using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigGadget : ConfigEntity
{
	public bool hasEquip;
	public bool hasAudio;
	public bool hasModel;
	public bool hasAbility;
	public bool hasDither;
	public bool hasFollowWindZoneRotation;
	public bool forceDontUseUpdateRigidbody;
	public bool hasConnectTrigger;
	public bool canBeCreatedOnPlatform;
	public uint connectTriggerPriority;
	public bool ignoreChildSceneProp;
	public bool moveRefreshGroundForceUp;
	public ConfigCombat combat;
	public string combatTemplate;
	public ConfigEntityAbilityEntry[] abilities;
	public ConfigTrigger field;
	public ConfigTimer timer;
	public ConfigMove move;
	public ConfigGadgetPattern gadget;
	public ConfigEquipment equipment;
	public ConfigNavigation navigation;
	public ConfigGadgetUI uiInteract;
	public ConfigGadgetMisc misc;
	public Dictionary<string, ConfigBaseStateLayer> stateLayers;
	public ConfigGadgetAudio audio;
	public ConfigAIBeta aibeta;
	public ConfigWeather weather;
	public ConfigWall wall;
	public ConfigFace face;
	public ConfigPartController partControl;
	public ConfigPaimon paimon;
	public bool radarHint;
	public bool keepModifierOutSight;
	public ConfigGadgetAction gadgetAction;
	public ConfigGadgetTurn gadgetTurn;
	public ConfigGlobalValueTurn gvTurn;
	public ConfigBillboard billboard;
	public ConfigIntee intee;
	public string[] bindEmotions;
	public bool projector;
	public bool lowPriorityIntee;
	public bool canRemoveByClient;
	public string[] tags;
	public bool canBeTriggeredByAvatarRay;
	public ConfigVehicle vehicle;
	public ConfigDangerZone dangerzone;
	public ConfigFishingZone fishingZone;
	public EntityType forceSetEntityType;
	public ConfigGadgetSpecialCamera cameraAdjust;
	public ConfigVODIntee vodIntee;
	public ConfigLivePlayer vodPlayer;
	public ConfigGadgetCameraBox cameraBox;
	public bool openWatcher;
	public uint rayTag;
	public bool hasRayTag;
	public bool useRetreatType;
	public bool dontDestroyByPerform;

	public class ConfigVODIntee
	{
		public uint excelConfigId;
	}
	public class ConfigVODPlayer
	{
		public VODPlayerType vodPlayerType;
	}
	public class ConfigLivePlayer : ConfigVODPlayer
	{
		public uint liveID;
		public float turnOnRadius;
		public float turnOffRadius;
		public Dictionary<uint, string> cuePointAbilityMap;
	}
	public class ConfigGadgetCameraBox
	{
		public string configName;
		public float enterRadius;
		public float exitRadius;
		public GadgetCameraBoxUIActionType uiAction;
	}
	public class ConfigGlobalValueTurn : ConfigGadgetTurn
	{
		public string globalValueName;
		public string avatarTargetPosGVKeyName;
		public Dictionary<uint, Vector> avatarTargetPosMap;
	}
	public class ConfigPolygonZone
	{
		public float checkCD;
	}
	public class ConfigFishingZone : ConfigPolygonZone
	{
		public float validRadius;
		public float fleeRadius;
		public bool disableInMultiplayer;
		public float bornRadius;
	}
	public class ConfigDangerZone : ConfigPolygonZone
	{
		public string[] zonelist;
	}
	public class ConfigGadgetSpecialCamera : ConfigSpecialCamera
	{
		public float enterAngle;
		public float exitAngle;
	}
	public class ConfigGadgetTurn
	{
		public string movePartAroundX;
		public string anchorPartAroundX;
		public string movePartAroundY;
		public string anchorPartAroundY;
		public string movePartAroundZ;
		public string anchorPartAroundZ;
		public ConfigWwiseString audioBeginTurningEvent;
		public ConfigWwiseString audioStopTurningEvent;
		public ConfigWwiseString audioBeginTurningEventAroundX;
		public ConfigWwiseString audioStopTurningEventAroundX;
		public ConfigWwiseString audioBeginTurningEventAroundY;
		public ConfigWwiseString audioStopTurningEventAroundY;
		public ConfigWwiseString audioBeginTurningEventAroundZ;
		public ConfigWwiseString audioStopTurningEventAroundZ;
		public Dictionary<uint, ConfigGadgetTurnState> turnStateMap;

		public class ConfigGadgetTurnState
		{
			public float angleAroundX;
			public float angleAroundY;
			public float angleAroundZ;
			public uint lerpCurveIndex;
			public float lerpTime;
		}
	}
	public class ConfigGadgetAction
	{
		public ConfigGadgetStateAction[] triggerEnterActionList;
		public ConfigGadgetStateAction[] gadgetStateActionList;
		public ConfigGadgetStateAction[] platformActionList;
		public ConfigGadgetStateAction[] interactActionList;
		public ConfigGadgetStateAction[] postUIInteractActionList;
	}
	public class ConfigPaimon
	{
		public Vector followOffSet;
		public float slowDownRangeXZ;
		public float slowDownRangeY;
		public float showRandomCDMin;
		public float showRandomCDMax;
	}
	public class ConfigWall
	{
		public string collisionEffectPattern;
		public float fadeDuration;
	}
	public class ConfigTimer
	{
		public bool lifeInfinite;
		public float startCheckTime;
		public float checkInterval;
		public float lifeTime;
	}
	public class ConfigEquipment
	{
		public string attachTo;
		public uint subGadgetId;
		public string subAttachTo;
		public string auxToTrans;
		public EquipEntityType equipEntityType;
		public ConfigBladeElementFx bladeFx;
		public ConfigBowData bowData;

		public class ConfigBowData
		{
			public string bowRatioName;
			public Vector bowStringLoosePoint;
			public float bowStringMaxLen;
		}
	}
	public class ConfigNavigation
	{
		public NavType type;
		public float sizeX;
		public float sizeY;
		public float sizeZ;
	}
	public class ConfigGadgetMisc
	{
		public ConfigChest chest;
		public ConfigGear gear;
		public ConfigConstForceField forceField;
		public ConfigCrystal crystal;
		public ConfigSeal seal;
		public ConfigPickup pickup;
		public ConfigWindSeed windSeed;
		public ConfigCannon cannon;
		public ConfigGadgetConsole gadgetConsole;
		public ConfigAutoDool autoDoor;
		public ConfigCustomGadgetNode customGadgetNode;
		public string escapeEffect;
		public bool guidePoint;
		public bool isUIPoint;
		public bool guidePointManagedByIndicator;
		public TargetIndicatorType guidePointType;
		public float targetIndicatorYOffset;
		public ConfigGuidePoint guidePointConfig;
	}

	public class ConfigWeather
	{
		public ConfigElemBall[] dropElemBalls;
		public string shapeName;
		public float[] position;
		public int priority;
		public string defaultEnviro;
		public string[] weatherList;
		public float[] weatherWeightList;
		public float refreshTime;

		public class ConfigElemBall
		{
			public ElemBallTriggerType type;
			public ElementType elementType;
			public int curMaxNum;
			public float[] intervalTimes;
			public uint[] dropItems;
			public uint[] dropCounts;
			public int maxNum;
			public float poissonDisk;
			public float minRadius;
			public float maxRadius;
		}
	}
}
