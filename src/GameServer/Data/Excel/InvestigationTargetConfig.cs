using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Data.Excel.Common;

namespace Weedwacker.GameServer.Data;

public class InvestigationTargetConfig : WatcherConfig
{
	public uint questId;
	public uint investigationId;
	public uint rewardId;
	public string icon;
	public string image;
	public uint infoDesTextMapHash;
	public QuestGuide guide;
}