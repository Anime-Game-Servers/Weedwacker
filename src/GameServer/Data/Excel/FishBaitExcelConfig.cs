using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FishBaitExcelConfig
{
	public uint id;
	public FishBaitFeature[] featureList;
	public byte sort;
	public uint[] poolIdList;

	public class FishBaitFeature
	{
		public uint featureTag;
		public float weight;
		public float bonusRange;
	}
}