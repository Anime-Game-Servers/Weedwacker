using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToWidgetStateMixin : ConfigAbilityMixin
{
	public uint targetWidgetMaterialId;
	public ConfigAbilityAction[] onActive;
	public ConfigAbilityAction[] onDisable;
	public ConfigAbilityAction[] onRemoved;
}
