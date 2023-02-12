using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarCodexExcelConfigData.json")]
public class AvatarCodexData
{
	public uint sortId;
	public int sortFactor;
	public uint avatarId;
	public string beginTime;
	public bool hideWhenDontHave;
}
