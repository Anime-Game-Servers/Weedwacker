using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarTalentExcelConfigData.json")]
public class AvatarTalentData
{
	public uint talentId;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public string icon;
	public uint prevTalent;
	public uint mainCostItemId;
	public uint mainCostItemCount;
	public uint viceCostItemId;
	public uint viceCostItemCount;
	public string openConfig;
	public PropValConfig[] addProps;
	public float[] paramList;
}
