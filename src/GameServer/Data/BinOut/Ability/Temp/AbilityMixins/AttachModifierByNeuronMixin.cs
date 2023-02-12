using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierByNeuronMixin : ConfigAbilityMixin
{
	public NeuronName[] neuronNameList;
	public NeuronMixinRemoveOperatorType removeOperator;
	public string modifierName;
	public bool authorityOnly;
}
