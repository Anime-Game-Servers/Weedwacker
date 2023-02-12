using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPlatformGrahpicsSetting
{
	public Dictionary<VolatileType, ConfigGraphicsVolatileSetting> volatileSettings;
	public Dictionary<string, ConfigGraphicsRecommendSetting> deviceSettings;
	public uint targetFrameRate;
	public AntialiasingMethod antialiasingMethod;
	public TAAQuality taaQuality;
	public SMAAQuality smaaQuality;
	public VolatileType[] candidateVolatile;
	public Dictionary<OptionType, ConfigPostprocessEffectSetting> postprocessEffectOptions;
	public Dictionary<OptionType, ConfigParticleEffectSetting> particleEffectOptions;
	public Dictionary<OptionType, ConfigComprehensiveQualitySetting> comprehensiveQualityOptions;
	public ConfigGraphicsSettingEntry[] settingEntry;
	public Dictionary<string, ConfigPerformanceSetting> performanceSettings;
	public ConfigGlobalToken globalTokenSettings;
	public Dictionary<ShadowQuality, ConfigShadowQualitySetting> shadowQualitySettings;
	public Dictionary<PerfCostRatioGrade, float> costRatioGrade;
	public Dictionary<string, int> levelStreamingCostMap;
	public Dictionary<FadeTintQualityLevel, ConfigTintFadeSetting> fadeDistanceQualitySettings;
	public string[] deviceModelUseWidthMatchMode;

	public class ConfigComprehensiveQualitySetting
	{
		public bool localLightingShadow;
		public int terrainBlendDistance;
		public int shaderLODDistance;
		public string shaderQualityKeyword;
		public string levelStreamingConfig;
		public string enviroConfig;
		public string uiCacheConfig;
		public float lightViewDistanceRatio;
		public GrassQualityLevel grassQuality;
		public LightLevel lightOnLevel;
		public string entityLODConfig;
		public bool enableRemoteAvatarLOD;
		public bool enableDynamicLight;
		public float fadeTintDistance;
		public float fadeTintSize;
		public float textureStreamingBudget;
		public FadeTintQualityLevel fadeTintQuality;
		public float terrainDistance;
		public float terrainNormal;
		public int shellCount;
		public int shellMaxObjectsCount;
		public bool useCrowdConeViewOptim;
		public int crowdMaxScreenNum;
		public int crowdConeViewUpdatePeriod;
	}
	public class ConfigGraphicsSettingEntry
	{
		public GraphicsSettingEntryType entryType;
		public string[] availableOptions;
		public float[] perfCostRatios;
		public SettingEntryDisplayType displayType;
		public float sliderMin;
		public float sliderMax;
		public float sliderInterval;
		public bool shouldCloudGameShow;
		public ConfigGraphicSettingEntrySortType sortOption;
	}
	public class ConfigGlobalToken
	{
		public string actionTokenGroup;
	}
	public class ConfigPerformanceSetting
	{
		public int scenePropCacheCount;
		public float bundleUnloadLRURetireTime;
		public int bundleUnloadLRURetireSize;
		public int bundleUnloadLRUCapcity;
		public int GameObjectPoolCount;
		public bool useFinalIK;
		public bool enableAudioSurfaceMultiprobing;
		public bool enableAudioFocusAttenuation;
		public bool enableAudioOcclusionRacasts;
		public bool enableAudioListenerOutreachDetetion;
		public float cachedEntityTime;
		public float cachedEntityDist;
		public bool useHeadControl;
		public bool useAvatarGrassDisplacement;
		public bool useOtherEnttiyGrassDisplacement;
		public bool useWindZoneGrassDisplacement;
		public bool useRagdoll;
		public bool useFBIK;
		public int windFlagMaxQualityLevel;
		public bool useDynamicBone;
		public int climbIKQualityLevel;
		public bool useClimbIK;
		public bool useMoveIK;
		public bool useEffectLOD;
		public int ragdollLimitCount;
		public int ragdollPoolSize;
		public int ragdollPoolSameIdSize;
	}
	public class ConfigParticleEffectSetting
	{
		public bool halfResolutionParticle;
		public ParticleEmitLevelType particleEmitLevel;
		public float particleDecreaseThresh;
	}
	public class ConfigShadowQualitySetting
	{
		public int shadowDistance;
		public ConfigShadowResolution shadowResolution;
		public int shadowCascadeSplitCount;
		public int perObjShadowQuality;
		public bool shadowBlend;
		public bool PerObjectPCF;
		public bool enableDynamicShadow;
		public bool enablePcss;
		public bool enableDistantShadow;
	}
	public class ConfigTintFadeSetting
	{
		public float tintDistance;
		public int tintSize;
	}
	public class ConfigPostprocessEffectSetting
	{
		public bool useHalfShadows;
		public bool useShadowCache;
		public CheckboardType checkboardType;
		public SSAOMode aoMode;
		public bool enableMotionBlur;
		public MotionBlurQuality motionBlurQuality;
		public float fsrScale;
		public int avatarMotionVectorStrategy;
	}
	public class ConfigGraphicsRecommendSetting
	{
		public string performanceQuality;
		public float virtualJoystickRadius;
		public string levelStreamingConfig;
		public string uiCacheConfig;
		public LightLevel lightOnLevel;
		public ConfigGraphicsRequirement[] requirements;
		public float textureStreamingBudget;
		public int enableCutsceneTextureStreaming;
		public int textureStreamingEnabled;
		public float textureStreamingOffset;
		public int enableUICameraFullResolution;
		public int preloadUIScene;
		public int disableDoF;
		public int enableSubpass;
		public int usePerObjectLightInForward;
		public ConfigRenderResolution[] renderResolutions;
		public string qualityLevel;
		public int defaultVolatileGrade;
		public float avatarOutlineThresh;
		public float avatarShadowThresh;
		public float avatarMotionVectorThresh;
		public float viewDistanceRatio;
		public GrassQualityLevel grassQuality;
		public int crowdSpawnDistance;
		public int crowdDespawnDistance;
		public string entityLODConfig;
		public string[] deviceExtraFrameRate;
		public Dictionary<VolatileType, int> overrideRenderResGrade;

		public class ConfigRenderResolution
		{
			public int width;
			public int height;
			public int secondWidth;
			public int secondHeight;
			public float perfCostRatio;
		}
	}
	public class ConfigGraphicsVolatileSetting
	{
		public uint frameRateGrade;
		public uint renderResolutionGrade;
		public uint shadowQualityGrade;
		public uint postprocessEffectGrade;
		public uint particleEffectGrade;
		public uint comprehensiveQualityGrade;
		public uint vSync;
		public uint AntiAliasing;
		public uint VolumetricFog;
		public uint Reflection;
		public uint MotionBlur;
		public uint Bloom;
		public uint CrowdDensity;
		public uint ObsoleteOnlineEffect;
		public uint ScreenSubsurfaceScattering;
		public uint OnlineEffect;
	}
}