using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType;

public class ConfigBulletPattern : ConfigGadgetPattern
{
	public ConfigBaseGadgetTriggerAction[] triggerActions;
	public ConfigBaseGadgetTriggerAction[] triggerLifeOverActions;
	public bool killByOther;
	public float dieDelayTime;
	public bool fireAISoundEvent;
	public float maxAutoKillDist;
	public float enableCollisionDelay;
}
