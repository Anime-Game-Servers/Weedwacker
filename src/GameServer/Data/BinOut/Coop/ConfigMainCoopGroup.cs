using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMainCoopGroup
{
	public Dictionary<uint, ConfigCoopInteractionGroup> coopInteractionMap;
	public Dictionary<uint, CoopSubStartPoint> subStartPointMap;
	public Dictionary<uint, CoopSavePoint> savePointMap;
	public uint confidenceValue;
	public uint maxConfidenceValue;
	public Dictionary<CoopTemperamentType, CoopTemperament> temperamentMap;
	public bool useConfidence;
	public bool useTemperament;
	public Dictionary<uint, CoopTempValue> coopTempValueMap;

	public class ConfigCoopInteractionGroup
	{
		public uint id;
		public Dictionary<uint, ConfigCoopBaseNode> coopMap;
		public uint startNodeId;
		public uint failNodeId;
	}
	public class CoopTempValue
	{
		public uint id;
		public uint value;
		public bool isCoopVar;
	}
	public class CoopTemperament
	{
		public uint value;
		public float ratio;
	}
	public class CoopSavePoint
	{
		public uint id;
		public bool isEnd;
	}
	public class CoopSubStartPoint
	{
		public uint id;
		public uint coopInteractionId;
	}
}