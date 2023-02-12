using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ReunionPrivilegeExcelConfig
{
	public uint id;
	public uint dailyNum;
	public uint totalNum;
	public ReunionPrivilegeConfig[] privilegeType;

	public class ReunionPrivilegeConfig
	{
		public ReunionPrivilegeType type;
		public string sub_type;
	}
}