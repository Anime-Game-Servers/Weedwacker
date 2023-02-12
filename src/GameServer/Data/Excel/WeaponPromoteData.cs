using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("WeaponPromoteExcelConfigData.json")]
public class WeaponPromoteData
{
	public uint weaponPromoteId;
	public uint promoteLevel;
	public IdCountConfig[] costItems;
	public uint coinCost;
	public PropValConfig[] addProps;
	public uint unlockMaxLevel;
	public uint requiredPlayerLevel;
}
