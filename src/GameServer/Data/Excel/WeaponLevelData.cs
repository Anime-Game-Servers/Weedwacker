using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("WeaponLevelExcelConfigData.json")]
public class WeaponLevelData : ItemConfig
{
	public uint level;
	public uint[] requiredExps;
}
