using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NpcExcelConfig : EntityExcelConfig
{
	public string jsonName;
	public byte jsonPathHashPre;
	public uint jsonPathHashSuffix;
	public string alias;
	public string scriptDataPath;
	public string luaDataPath;
	public uint luaDataIndex;
	public bool hasCombat;
	public bool hasMove;
	public bool hasAudio;
	public bool isDaily;
	public string dyePart;
	public BillboardType billboardType;
	public string billboardIcon;
	public bool invisiable;
	public bool disableShowName;
	public string templateEmotionPath;
	public byte animatorConfigPathHashPre;
	public uint animatorConfigPathHashSuffix;
	public NPCBodyType bodyType;
	public uint firstMetId;
	public uint uniqueBodyId;
	public bool isActivityDailyNpc;
	public bool useDynBone;
	public bool skipInitClosetToGround;
	public bool isRelease;
}