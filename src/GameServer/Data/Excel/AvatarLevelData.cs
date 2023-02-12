using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarLevelExcelConfigData.json")]
public class AvatarLevelData
{
	public uint Level;
	public uint Exp;
	public uint smallTalentPoint;
}
