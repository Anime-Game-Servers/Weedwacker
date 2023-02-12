using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetGlobalValue : ConfigAbilityPredicate
{
	public string key;
	public object value;
	public object maxValue;
	public bool forceByCaster;
	public RelationType compareType;
}
