using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigJudgeNodeContainer : ConfigJudgeNodeBase
{
	public ConfigJudgeNodeBase[] subNodes;
	public LogicType subNodeLogicComb;
}