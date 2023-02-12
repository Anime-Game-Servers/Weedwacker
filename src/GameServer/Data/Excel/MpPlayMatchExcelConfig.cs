using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MpPlayMatchExcelConfig
{
	public uint id;
	public MpPlayType playType;
	public uint playNameTextMapHash;
	public uint playDescTextMapHash;
	public bool isAutoMatch;
	public uint minPlayers;
	public uint maxPlayers;
	public bool isAllowInAnyTime;
	public bool isMatchNecessary;
	public MpPlaySettleType settleType;
	public uint seriesId;
	public uint[] buffList;
	public uint pushTipsId;
	public string bgImage;
	public bool noProgress;
}