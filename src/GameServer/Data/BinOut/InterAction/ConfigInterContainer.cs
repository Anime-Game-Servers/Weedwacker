using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigInterContainer
{
	public string luaDataPath;
	public bool isSimpleTalk;
	public bool dontUseDefaultFinish;
	public bool attackModeRecover;
	public bool pauseActor;
	public bool hidePickableEntity;
	public float startBlackKeepTime;
	public string entityBan;
	public bool isKeyInteraction;
	public bool disableNpcLod;
	public bool isAutoBanNpc;
	public bool isBanWidgetPet;
	public int[] BanCrowdGroupIDs;
	public bool protectNpcMobileLod;
	public ConfigInterFade startFade;
	public ConfigInterFade endFade;
	public ConfigInterActor[] actors;
	public ConfigBaseInterAction[][] group;
	public ConfigInterGrpId[] groupId;
	public Dictionary<uint, int[]> freeStyleDic;

	public class ConfigInterFade
	{
		public float startFadeInDuration;
		public float startFadeOutDuration;
	}
	public class ConfigInterActor
	{
		public uint configID;
		public string alias;
		public bool visible;
		public string bornPointName;
		public bool useRelativePos;
		public Vector relativePos;
		public Vector relativeRot;
		public uint questID;
		public RemoveActorType removeActorType;
		public bool forceCreateDaily;
		public ActorBornRelativePosType relativePosType;
		public string relativePosNpcAlias;
	}
	public class ConfigInterGrpId
	{
		public uint index;
		public uint grpId;
		public uint nextGrpId;
	}
}