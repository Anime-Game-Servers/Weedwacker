using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ReputationEntranceExcelConfig
{
	public uint textId;
	public ReputationEntranceType entranceId;
	public uint cityId;
	public LogicType condComb;
	public ReputationEntranceCond[] condVec;
	public uint[] condNameVec;
	public uint nameTextMapHash;
	public uint titleTextMapHash;
	public uint explainTitleTextMapHash;
	public uint descTextMapHash;
	public string iconName;
	public uint order;

	public class ReputationEntranceCond
	{
		public ReputationEntranceCondType type;
		public uint param1;
		public uint param2;
	}
}