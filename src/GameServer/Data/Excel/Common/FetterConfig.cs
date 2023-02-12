using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FetterConfig
{
	public uint fetter_id;
	public uint avatarId;
	public FetterConditionConfig[] openConds;
	public FetterConditionConfig[] finishConds;
}