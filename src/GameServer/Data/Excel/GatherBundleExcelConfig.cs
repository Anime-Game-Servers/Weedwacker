using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GatherBundleExcelConfig
{
	public uint id;
	public string bundleName;
	public uint baseGadgetId;
	public PointInfo[] points;

	public class PointInfo
	{
		public uint pointID;
		public uint pointType;
		public float offsetX;
		public float offsetY;
		public float offsetZ;
		public float rotX;
		public float rotY;
		public float rotZ;
	}
}