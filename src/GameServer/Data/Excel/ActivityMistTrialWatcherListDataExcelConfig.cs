using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityMistTrialWatcherListDataExcelConfig
{
	public uint Id;
	public uint scheduleId;
	public uint challengeWatcherId;
	public MistTrialClientSyncType dungeonShowContentType;
	public string[] showParam;
	public uint progressFormatTextMapHash;
	public bool isNeedShowProgress;
	public uint hintFormatTextMapHash;
}