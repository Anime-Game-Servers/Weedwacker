using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns;

public class ConfigAttackCircle : ConfigSimpleAttackPattern
{
	public float height;
	public float fanAngle;
	public object radius;
	public object innerRadius;
	public CircleDetectDirection detectDirection;
}
