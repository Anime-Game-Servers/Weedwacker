using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetNeuronMute : ConfigAbilityAction
{
	public NeuronName neuronName;
	public bool enable;
}