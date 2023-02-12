using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("GatherExcelConfigData.json")]
public class GatherData
{
	public uint id;
	public uint area_id;
	public uint pointType;
	public uint gadgetId;
	public uint itemId;
	public uint[] extraItemIdVec;
	public PointLocation pointLocation;
	public uint cd;
	public uint priority;
	public uint refreshId;
	public BlockLimit[] blockLimits;
	public bool init_disable_interact;
	public bool isForbidGuest;
	public GatherSaveType saveType;
	public bool isForbidMpMode;

	public class BlockLimit
	{
		public uint blockIdRawNum;
		public uint countRawNum;
	}
}
