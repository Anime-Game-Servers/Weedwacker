using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttackHittingSceneMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onHittingScene;
	public string[] animEventIDs;
}
