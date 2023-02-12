using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCoopActionNode : ConfigCoopBaseNode
{
	public ConfigCoopAction[] actionList;

	public class ConfigCoopAction
	{
		public CoopActionType actionType;
		public int[] param;
	}
}