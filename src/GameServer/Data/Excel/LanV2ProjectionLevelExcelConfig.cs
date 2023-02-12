using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LanV2ProjectionLevelExcelConfig
{
	public uint levelId;
	public uint stageId;
	public uint watcherId;
	public uint levelNameTextMapHash;
	public string iconSilhouette;
	public string iconNormal;
	public float endDialogIconOffsetX;
	public float endDialogIconOffsetY;
	public float endDialogIconScale;
	public uint sceneSuiteId;
	public uint rootPointSwitchButtonConfigId;
	public float[] rootPointCorrectPose;
	public float[] rootPointInitialPose;
	public LanV2ProjectionRootPointMotionType rootPointMotionType;
	public float[] rootPointFreeRotationTolerance;
	public float[] rootPointSingleAxisRotationAxis;
	public float[] rootPointSingleAxisRotationLimit;
	public float rootPointSingleAxisRotationTolerance;
	public uint[][] hierarchy;
	public LanV2ProjectionElementConfig[] elementConfigs;

	public class LanV2ProjectionElementConfig
	{
		public string prefabPath;
		public string shadowPrefabPath;
		public uint switchButtonConfigId;
		public float[] correctPose;
		public float[] initialPose;
		public LanV2ProjectionMotionType motionType;
		public float[] freeRotationTolerance;
		public float[] singleAxisMotionAxis;
		public float[] singleAxisMotionLimit;
		public float singleAxisMotionTolerance;
	}
}