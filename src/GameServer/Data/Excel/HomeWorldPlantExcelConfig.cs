using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HomeWorldPlantExcelConfig
{
	public uint seedID;
	public uint[] gatherIdVec;
	public uint homeGatherID;
	public uint bundleID;
	public uint dropID;
	public ConfigHomeGather[] configHomeGather;
	public uint fieldID;
	public uint time;
	public uint sproutTime;
	public uint collectNum;
	public uint sproutGadgetID;
	public uint order;
	public string inteeIconName;
	public uint inteeNameTextMapHash;

	public class ConfigHomeGather
	{
		public uint homeGatherID;
		public uint bundleID;
		public uint dropID;
		public uint weight;
	}
}