using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BlessingScanExcelConfig
{
	public uint id;
	public uint typeId;
	public BlessingScanType scanType;
	public uint refId;
	public BlessingPicUpConfig[] picUpConfig;
	public uint scanDuration;
	public uint scanTime;
	public string hitBoxesNodeName;

	public class BlessingPicUpConfig
	{
		public uint id;
		public uint prob;
	}
}