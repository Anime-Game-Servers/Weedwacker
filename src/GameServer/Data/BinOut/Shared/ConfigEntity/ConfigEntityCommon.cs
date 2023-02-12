using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigEntityCommon
{
	public ConfigEffectAttachShape effectAttachShape;
	public float mass;
	public float height;
	public float modelHeight;
	public float viewSize;
	public float shadowViewSizeRatio;
	public float overrideCullBoundsRadius;
	public bool affectedByWorld;
	public bool checkInSurface;
	public float scale;
	public float disableTickDistance;
	public float forcePauseTickDistance;
	public bool shouldPauseAnimatorBeforeReady;
	public bool canTriggerElementReactionText;
	public bool useGrassDisplacement;
	public bool muteElementStickUI;
	public bool hasAfterImage;
	public bool useDynamicBone;
	public bool enableCrashDamage;
	public bool clearAnimatorOnSetLightDeactive;
	public bool clearAIOnSetLightDeactive;
	public bool useFinalIK;
	public float elementReactionScale;
	public float chargeBarHeightOffset;
}
