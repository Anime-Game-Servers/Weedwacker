using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideSwitchInputContextAction : ConfigGuideAction
{
	public string[] inputEventList;
	public string[] contextEventList;
	public int[] inputPriorityList;
}