using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Data.Excel.Common;

namespace Weedwacker.GameServer.Data;

public class BattlePassMissionExcelConfig : WatcherConfig
{
	public BattlePassMissionRefreshType refreshType;
	public bool isForce;
	public uint addPoint;
	public uint scheduleId;
	public uint activityId;
	public uint descTextMapHash;
	public QuestGuide guide;
}