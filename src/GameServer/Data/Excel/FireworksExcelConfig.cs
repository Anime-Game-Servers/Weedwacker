using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FireworksExcelConfig
{
	public uint materialID;
	public FireworksReformParamConfig[] reformParamList;
	public FireworksType fireworksType;
	public string liftOffEffectName;
	public string explodeEffectName;
	public uint detailedDescTextMapHash;

	public class FireworksReformParamConfig
	{
		public FireworksReformParamType type;
		public int standardValue;
		public bool isCanReform;
		public int[] valueRange;
	}
}