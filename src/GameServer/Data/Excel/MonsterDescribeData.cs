using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("MonsterDescribeExcelConfigData.json")]
internal class MonsterDescribeData
{
	public uint id;
	public uint nameTextMapHash;
	public uint titleId;
	public uint specialNameLabID;
	public string icon;
}
