using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RandTaskRewardConfig
{
	public uint ID;
	public RandTaskDropConfig[] dropVec;

	public class RandTaskDropConfig
	{
		public uint dropId;
	}
}