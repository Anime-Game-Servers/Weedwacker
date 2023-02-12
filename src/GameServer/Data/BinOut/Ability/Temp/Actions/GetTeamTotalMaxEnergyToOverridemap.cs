using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class GetTeamTotalMaxEnergyToOverridemap : ConfigAbilityAction
{
	public TeamType teamType;
	public string overrideMapKey;
}
