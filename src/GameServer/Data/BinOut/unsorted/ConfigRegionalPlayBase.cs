using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRegionalPlayBase
{
	public RegionalPlayType playType;
	public uint bindScene;
	public string[] abilityGroupNameList;
	public bool isTeam;
	public ConfigRegionalPlayVarData[] varList;
}