using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TrialAvatarFetterDataConfig
{
	public uint avatarId;
	public uint fetterId;
	public TrialFetterConditionConfig finishCond;

	public class TrialFetterConditionConfig
	{
		public TrialFetterConditionType condType;
		public uint[] paramList;
	}
}