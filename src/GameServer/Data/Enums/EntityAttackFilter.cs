
namespace Weedwacker.GameServer.Data.Enums;

public enum EntityAttackFilter : int
{
	AllEntities = 0,
	OnlyWater = 1,
	OnlyGrass = 2,
	OnlyGrassAndWater = 3,
	IgnoreSceneProp = 4,
}