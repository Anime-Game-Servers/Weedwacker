using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigVisibleInterAction : ConfigBaseInterAction
{
	public bool isVisible;
	public bool useDither;
	public InterActionTargetType target;
}