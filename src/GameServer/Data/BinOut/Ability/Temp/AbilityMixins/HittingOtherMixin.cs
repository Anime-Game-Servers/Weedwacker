using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class HittingOtherMixin : ConfigAbilityMixin
{
	public Predicated[] onHittingOther;
}
