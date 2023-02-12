using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp;

public class SelectTargets
{
	public int topLimit;
	public EntityType[] entityTypePriority;
	public SelectTargetsSortType sortType;
}
