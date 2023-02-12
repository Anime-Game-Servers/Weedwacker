using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToGadgetStateMutexMixin : ConfigAbilityMixin
{
	public int[] gadgetStates;
	public string[][] modifierNames;
}
