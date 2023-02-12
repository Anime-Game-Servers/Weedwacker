using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class BroadcastNeuronStimulate : ConfigAbilityAction
{
	public NeuronName neuronName;
	public bool stimulate;
	public float range;
}
