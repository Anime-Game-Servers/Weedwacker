using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ReliquaryAffixExcelConfigData.json")]
public class ReliquaryAffixData
{
	public uint id;
	public uint depot_id;
	public uint group_id;
	public FightPropType propType;
	public float propValue;
}
