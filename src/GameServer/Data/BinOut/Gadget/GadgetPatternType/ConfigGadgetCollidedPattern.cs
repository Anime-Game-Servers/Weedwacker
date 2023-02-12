using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType;

public class ConfigGadgetCollidedPattern : ConfigGadgetPattern
{
	public ConfigBaseGadgetTriggerAction[] collisionActions;
	public string thisColliderName;
	public string targetColliderName;
}
