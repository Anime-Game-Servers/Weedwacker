using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CaptureExcelConfig
{
	public uint monsterID;
	public CaptureTagConfig[] captureTagConfig;

	public class CaptureTagConfig
	{
		public uint captureType;
		public uint dropID;
		public uint itemID;
	}
}