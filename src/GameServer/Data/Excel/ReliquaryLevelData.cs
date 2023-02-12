using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ReliquaryLevelExcelConfigData.json")]
public class ReliquaryLevelData
{
	public uint rank;
	public uint level;
	public uint exp;
	public PropValConfig[] addProps;
}
