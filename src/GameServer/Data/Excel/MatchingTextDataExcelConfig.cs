using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MatchingTextDataExcelConfig
{
	public uint matchId;
	public byte matchIconHashPre;
	public uint matchIconHashSuffix;
	public string matchBtnName;
	public string matchBtnTips;
	public uint requirementDescTextMapHash;
	public uint matchLimitReasonDescTextMapHash;
	public uint limitWarningDescTextMapHash;
	public uint inviteGuestDescTextMapHash;
	public uint inviteHostDescTextMapHash;
	public string matchStartDesc;
	public uint matchTitleTextMapHash;
	public uint matchSuccessDescTextMapHash;
}