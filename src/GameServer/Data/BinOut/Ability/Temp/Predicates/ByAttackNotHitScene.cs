using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByAttackNotHitScene : RelationalOperationPredicate
{
	public ConfigBaseAttackPattern attackPattern;
	public bool checkWaterLayer;
}