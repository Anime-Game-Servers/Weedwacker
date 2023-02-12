using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Excel.Common;

namespace Weedwacker.GameServer.Data.Excel;

public class HideAndSeekMatchExcelConfig : MatchLimitExcelConfig
{
	public uint titleTextMapHash;
	public uint unlockTipsTextMapHash;
	public uint unlockTips2TextMapHash;
	public uint unlockTips3TextMapHash;
	public uint dscTextMapHash;
	public byte mapIconPathHashPre;
	public uint mapIconPathHashSuffix;
	public byte mapSmallIconPathHashPre;
	public uint mapSmallIconPathHashSuffix;
	public uint sceneId;
	public uint groupId;
	public uint[] transportPointList;
	public uint[] durationList;
	public uint galleryID;
}