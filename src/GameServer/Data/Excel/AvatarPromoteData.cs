using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarPromoteExcelConfigData.json")]
public class AvatarPromoteData
{
	public uint avatarPromoteId;
	public uint promoteLevel;
	public string promoteAudio;
	public uint scoinCost;
	public IdCountConfig[] costItems;
	public uint unlockMaxLevel;
	public PropValConfig[] addProps;
	public uint requiredPlayerLevel;
}
