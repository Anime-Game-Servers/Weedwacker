using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttackChainReceiverMixin : ConfigAbilityMixin
{
	public object cd;
	public ConfigAbilityAction[] actionQueue;
}
