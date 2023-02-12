
namespace Weedwacker.GameServer.Data.Enums;

public enum TurnMode : int
{
	PreferTargetToInput = 0,
	OnlyInput = 1,
	OnlyTarget = 2,
	PreferTargetToCamera = 3,
	OnlyCamera = 4,
}