using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("BlossomChestExcelConfigData.json")]
public class BlossomChestData
{
	public uint id;
	public uint chestGadgetId;
	public uint worldResin;
	public uint resin;
	public BlossomRefreshType refreshType;
	public BlossomChestShowType clientShowType;
}
