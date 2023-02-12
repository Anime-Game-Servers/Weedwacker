using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("EquipAffixExcelConfigData.json")]
public class EquipAffixData
{
	public uint affixId;
	public uint id;
	public uint level;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public string openConfig;
	public PropValConfig[] addProps;
	public float[] paramList;
}
