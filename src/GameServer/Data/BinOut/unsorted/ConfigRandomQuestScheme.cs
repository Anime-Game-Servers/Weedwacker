using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRandomQuestScheme
{
	public uint id;
	public Dictionary<uint, int[]> freeStyleDic;
	public Dictionary<string, int[]> randomFreeStyleDic;
}