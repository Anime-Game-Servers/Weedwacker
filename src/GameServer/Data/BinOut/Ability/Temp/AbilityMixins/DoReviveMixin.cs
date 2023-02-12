using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoReviveMixin : ConfigAbilityMixin
{
	public AvatarStageType type;
	public bool ignoreDieAbyss;
	public bool ignoreDieDrawn;
	public ConfigAbilityAction[] onKillActions;
	public ConfigAbilityAction[] onReviveActions;
}
