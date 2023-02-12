using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ReliquaryMainPropExcelConfigData.json")]
public class ReliquaryMainPropData
{
	public uint id;
	public uint prop_depot_id;
	public FightPropType propType;
	public ReliquaryMainAffixName affixName;
}
