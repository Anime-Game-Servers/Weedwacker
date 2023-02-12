using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("TeamResonanceExcelConfigData.json")]
public class TeamResonanceData
{
	public uint teamResonanceId;
	public uint teamResonanceGroupId;
	public uint level;
	public uint fireAvatarCount;
	public uint waterAvatarCount;
	public uint grassAvatarCount;
	public uint electricAvatarCount;
	public uint iceAvatarCount;
	public uint windAvatarCount;
	public uint rockAvatarCount;
	public TeamResonanceCondType cond;
	public uint minTotalPromoteLevel;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public string openConfig;
	public PropValConfig[] addProps;
	public float[] paramList;
}
