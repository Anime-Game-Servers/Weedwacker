using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideAddCmd : ConfigGuideAction
{
	public GuideCmdType cmdType;
	public float paraValue;
}