using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByEnergyChangeMixin : ConfigAbilityMixin
{
	public AvatarStageType type;
	public ElementType[] elementTypes;
	public bool doWhenEnergyMax;
	public ConfigAbilityAction[] onGainEnergyByBall;
	public ConfigAbilityAction[] onGainEnergyByOther;
	public ConfigAbilityAction[] onGainEnergyByAll;
	public ConfigAbilityAction[] onGainEnergyMax;
}
