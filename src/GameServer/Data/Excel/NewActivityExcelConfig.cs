using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NewActivityExcelConfig
{
	public uint activityId;
	public NewActivityType activityType;
	public uint nameTextMapHash;
	public string activitySceneTag;
	public bool isLoadTerrain;
	public uint[] condGroupId;
	public uint[] watcherId;
	public bool isBanClientUi;
}