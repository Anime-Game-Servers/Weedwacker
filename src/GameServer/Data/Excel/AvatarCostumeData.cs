using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarCostumeExcelConfigData.json")]
public class AvatarCostumeData
{
	public uint skinId;
	public uint indexID;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public uint itemId;
	public uint characterId;
	public string json_name;
	public byte prefab_pathHashPre;
	public uint prefab_pathHashSuffix;
	public byte prefab_remote_pathHashPre;
	public uint prefab_remote_pathHashSuffix;
	public byte prefab_npc_pathHashPre;
	public uint prefab_npc_pathHashSuffix;
	public byte animatorConfigPathHashPre;
	public uint animatorConfigPathHashSuffix;
	public byte prefab_manekin_pathHashPre;
	public uint prefab_manekin_pathHashSuffix;
	public byte controller_pathHashPre;
	public uint controller_pathHashSuffix;
	public byte controller_remote_pathHashPre;
	public uint controller_remote_pathHashSuffix;
	public bool isDefault;
	public bool isDefaultUnlock;
	public uint quality;
	public bool hide;
	public string frontIconName;
	public string sideIconName;
	public byte imageNameHashPre;
	public uint imageNameHashSuffix;
	public bool domesticHideInArtPreview;
	public bool overseaHideInArtPreview;
}