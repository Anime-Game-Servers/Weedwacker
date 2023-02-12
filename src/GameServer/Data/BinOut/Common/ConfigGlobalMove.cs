using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGlobalMove
{
	public ConfigMoveSyncInterval syncInterval;
	public bool noGroundStayInPlace;

	public class ConfigMoveSyncInterval
	{
		public ConfigSpecificFloatValue lod0;
		public ConfigSpecificFloatValue lod1;
		public ConfigSpecificFloatValue lod2;

		public class ConfigSpecificFloatValue
		{
			public float defaultValue;
			public Dictionary<string, float> specificValue;
		}
	}
}