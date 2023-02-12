using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByCreateGadgetMixin : ConfigAbilityMixin
{
	public CreateGadgetMixinType type;
	public ConfigAbilityAction[] actionQueue;
}
