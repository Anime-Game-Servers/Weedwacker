using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetNeuronEnable : ConfigAbilityAction
{
	public NeuronName neuronName;
	public bool enable;
}
