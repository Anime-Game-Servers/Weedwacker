using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarFlycloakExcelConfigData.json")]
public class AvatarFlycloakData
{
	public uint flycloakId;
	public ulong nameTextMapHash;
	public uint descTextMapHash;
	public string prefab_path;
	public string json_name;
	public string icon;
	public uint materialId;
	public bool hide;
}
