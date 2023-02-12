using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class EnviroFollowRotateMixin : ConfigAbilityMixin
{
	public Vector selfRotateOffSet;
	public string deactiveOnCutsecneName;
}
