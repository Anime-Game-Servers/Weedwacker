using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AvatarStrafeFuelMixin : ConfigAbilityMixin
{
	public float initFuel;
	public float costSpeed;
	public RemoveUniqueModifier[] onEmptied;
}
