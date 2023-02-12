using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NewActivityAvatarSelectionExcelConfig
{
	public uint scheduleId;
	public uint condId;
	public uint[] watcherIdList;
	public uint[] avatarRewardList;
	public uint descTextMapHash;
	public uint[] costItemIdList;
	public uint[] costItemNumList;
	public bool isBlocked;
}