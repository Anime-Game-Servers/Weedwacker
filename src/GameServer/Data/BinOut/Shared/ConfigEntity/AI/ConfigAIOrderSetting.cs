
namespace Weedwacker.GameServer.Data;

public class ConfigAIOrderSetting
{
	public ConfigAIOrderMasterSetting master;
	public ConfigAIOrderServantSetting servant;
	public ConfigAICommandSetting commandSetting;

	public class ConfigAIOrderMasterSetting
	{
		public bool enable;
		public int servantSlotAmount;
	}
	public class ConfigAIOrderServantSetting
	{
		public bool enable;
	}
	public class ConfigAICommandSetting
	{
		public int[] acceptCommandIDs;
	}
}