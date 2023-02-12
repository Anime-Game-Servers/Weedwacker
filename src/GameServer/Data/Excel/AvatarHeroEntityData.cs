using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarHeroEntityExcelConfigData.json")]
public class AvatarHeroEntityData
{
	public uint avatarId;
	public byte prefabPathHashPre;
	public uint prefabPathHashSuffix;
	public byte animatorConfigPathHashPre;
	public uint animatorConfigPathHashSuffix;
}
