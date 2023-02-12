using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns;

public class ConfigAttackSphere : ConfigSimpleAttackPattern
{
	public object radius;
	public SphereDetectDirection detectDirection;
}
