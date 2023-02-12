using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns;

public class ConfigAttackBox : ConfigSimpleAttackPattern
{
	public object size;
	public bool muteHitBehindScene;
}
