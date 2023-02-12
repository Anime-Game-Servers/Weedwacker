using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class OnAvatarUseSkillMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onTriggerNormalAttack;
	public ConfigAbilityAction[] onTriggerSkill;
	public ConfigAbilityAction[] onTriggerUltimateSkill;
	public bool useSkillStart;
	public float clearSkillIdDelay;
}
