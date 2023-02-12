using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBaseCutscene
{
	public CutsceneType type;
	public ConfigCutscenePreTask preTaskCfg;
	public bool canSkip;
	public bool forceCanSkip;
	public bool skipGeneralDialog;
	public bool can;
	public bool clearBlackScreen;
	public float fadeOutWhenFinish;
	public bool directTransmit;
	public float delayTransmit;
	public string luaDataPath;
	public string resPath;
	public string castListPath;
	public string entityBan;
	public CutsceneInitPosType startPosType;
	public Vector startOffset;
	public bool needXZEuler;
	public bool needYEuler;
	public bool keepCamera;
	public bool useTargetPos;
	public Vector targetPos;
	public bool modifyLastPoseOffset;
	public bool attackModeRecover;
	public int[] crowdLOD0List;
	public bool enableCameraDisplacement;
	public uint entityRuntimeID;
	public bool clearAvatarLocalGadget;
	public bool disableGPUCulling;
	public bool canPlayerLoop;
	public uint mainQuestId;
	public bool disableAvatarLocalGadget;

	public class ConfigCutscenePreTask
	{
		public float duration;
		public float targetDayTime;
		public string targetWeather;
	}
}