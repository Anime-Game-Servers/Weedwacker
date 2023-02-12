using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class StageReadyMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onStageReady;
}
