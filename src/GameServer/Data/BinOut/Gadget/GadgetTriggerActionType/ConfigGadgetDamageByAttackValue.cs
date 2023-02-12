using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType;

public class ConfigGadgetDamageByAttackValue : ConfigBaseGadgetTriggerAction
{
	public ConfigBornType born;
	public ConfigAttackInfo attackInfo;
}
