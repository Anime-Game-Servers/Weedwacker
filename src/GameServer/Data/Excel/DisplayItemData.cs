using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("DisplayItemExcelConfigData.json")]
public class DisplayItemData : ItemConfig
{
	public uint typeDescTextMapHash;
	public uint rankLevel;
	public DisplayItemType displayType;
	public uint param;
}
