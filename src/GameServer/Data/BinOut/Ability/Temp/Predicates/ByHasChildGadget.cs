using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHasChildGadget : ConfigAbilityPredicate
{
	public uint[] configIdArray;
	public uint value;
	public RelationType compareType;
	public bool forceByCaster;
	public bool checkEntityAlive;
}
