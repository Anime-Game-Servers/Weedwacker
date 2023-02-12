using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RoutineDetailExcelConfig
{
	public uint routineId;
	public GeneralRoutineType routineType;
	public uint groupId;
	public uint tag;
	public bool is_backup;
	public uint rewardId;
	public RoutineFinishContent finishContent;
	public LogicType condComb;
	public RoutineCondContent[] condVec;
	public RoutineActionContent[] actionVec;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public uint goalTextMapHash;
	public string centerPosition;
	public uint radarRadius;
	public uint enterDistance;
	public uint exitDistance;

	public class RoutineFinishContent
	{
		public RoutineFinishType finishType;
		public uint param1;
		public uint param2;
		public uint progress;
	}
	public class RoutineCondContent
	{
		public RoutineCondType type;
		public uint param1;
		public uint param2;
	}
	public class RoutineActionContent
	{
		public RoutineActionype type;
		public uint param1;
		public uint param2;
	}
}