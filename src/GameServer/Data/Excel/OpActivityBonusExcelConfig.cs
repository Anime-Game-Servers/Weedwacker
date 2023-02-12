using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class OpActivityBonusExcelConfig
{
	public uint bonusId;
	public OpActivityBonusSourceType sourceType;
	public string sourceParam;
	public uint openLevel;
	public uint bonusRatio;
	public string[] textMapIdList;
	public OpActivityTrackType trackType;
	public uint[] trackPara;
	public uint iconBackground;
	public uint iconForeground;
}