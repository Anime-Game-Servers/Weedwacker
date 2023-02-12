using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGlobalValues
{
	public Dictionary<NPCBodyType, FirstPersonCoopCamConfig> firstPersonCoopCamConfigs;
	public Dictionary<string, ConfigGadgetUIItemGroupShowCond[]> gadgetUIItemGroupShowCondsConfigs;
	public float specialElementViewESLValue;

	public class ConfigGadgetUIItemGroupShowCond
	{
		public GadgetUIItemGroupShowCondType showCondType;
		public uint priority;
	}
	public class FirstPersonCoopCamConfig
	{
		public Vector camPositionOffset;
		public Vector camTargetOffset;
		public float camFOV;
	}
}