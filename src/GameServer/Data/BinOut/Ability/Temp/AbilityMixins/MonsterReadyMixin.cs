using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class MonsterReadyMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onMonsterReady;
}
