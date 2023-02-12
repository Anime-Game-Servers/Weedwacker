using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DragonSpineMissionExcelConfig
{
	public uint id;
	public uint chapterId;
	public uint watcherId;
	public DragonSpineMissionFinishConfig[] finishExec;

	public class DragonSpineMissionFinishConfig
	{
		public DragonSpineMissionFinishExecType type;
		public string[] param;
	}
}