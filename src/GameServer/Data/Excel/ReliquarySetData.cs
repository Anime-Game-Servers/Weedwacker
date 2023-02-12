using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ReliquarySetExcelConfigData.json")]
public class ReliquarySetData
{
	public uint setId;
	public string setIcon;
	public uint[] setNeedNum;
	public uint EquipAffixId;
	public uint DisableFilter;
	public uint[] containsList;
	public uint bagSortValue;
}
