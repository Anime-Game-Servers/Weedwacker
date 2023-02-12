using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigJudgeEntityInViewByEntityConfigID : ConfigJudgeNodeBase
{
	public ConfigJudgeEntityInViewData[] scanEntityList;
	public ScanAreaType scanAreaType;
	public float widthRatio;
	public float heightRatio;
	public float scanRangeNearZ;
	public float scanRangeFarZ;
	public bool scanEnableRayCast;

	public class ConfigJudgeEntityInViewData
	{
		public uint entityConfigID;
		public uint[] scannableStates;
	}
}