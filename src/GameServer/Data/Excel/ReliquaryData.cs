using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ReliquaryExcelConfigData.json")]
public class ReliquaryData : ItemConfig
{
	public EquipType equipType;
	public string showPic;
	public uint rankLevel;
	public uint mainPropDepotId;
	public uint appendPropDepotId;
	public uint appendPropNum;
	public uint setId;
	public uint[] addPropLevels;
	public uint baseConvExp;
	public uint maxLevel;
	public uint storyId;
	public MaterialDestroyType destroyRule;
	public uint[] destroyReturnMaterial;
	public uint[] destroyReturnMaterialCount;
	public uint initialLockState;
}
