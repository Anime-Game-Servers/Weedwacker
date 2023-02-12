using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideMultiPlayerCondition : ConfigGuideCondition
{
	public bool isIn;
	public int playerNum;
	public GuideOperator opt;
	public GuideMultiPlayerMode mode;
}