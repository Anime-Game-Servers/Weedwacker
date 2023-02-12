using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToPlayStageMixin : ConfigAbilityMixin
{
	public uint stage;
	public ConfigAbilityAction[] actions;
}
