using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ExtendLifetimeByPickedGadgetMixin : ConfigAbilityMixin
{
	public uint[] pickedConfigIDs;
	public object extendLifeTime;
	public object maxExtendLifeTime;
}
