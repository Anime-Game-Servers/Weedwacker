using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LanV2FireworksOverallDataExcelConfig
{
	public uint scheduleId;
	public uint initStaminaValue;
	public FireElementAdditionConfig[] fireElementAdditionList;
	public float scoreFormulaExponent;
	public float scoreFormulaOffset;
	public uint pushTipsId;

	public class FireElementAdditionConfig
	{
		public uint[] range;
		public uint ratio;
	}
}