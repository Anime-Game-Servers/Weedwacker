using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class SignInCondExcelConfig
{
	public uint configId;
	public LogicType condComb;
	public SignInCondConfig[] condList;
	public uint totalDayCount;
}