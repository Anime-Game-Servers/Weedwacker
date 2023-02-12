using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RegionSearchCondExcelConfig
{
	public uint id;
	public uint searchNameTextMapHash;
	public uint searchDescTextMapHash;
	public uint searchMapDescTextMapHash;
	public uint groupId;
	public LogicType logicType;
	public RegionSearchCond[] cond;
	public uint[] regionList;
	public uint rewardId;
	public uint totalProgress;
	public uint reminderId;

	public class RegionSearchCond
	{
		public RegionSearchCondType type;
		public int[] param;
	}
}