using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp;

public class ConfigAbilityAction : BaseActionContainer, IInvocation
{
	public ConfigAbilityActionToken token;
	public AbilityTargetting target;
	public SelectTargets otherTargets;
	public bool doOffStage;
	public bool doAfterDie;
	public bool canBeHandledOnRecover;
	public bool muteRemoteAction;
	public ConfigAbilityPredicate[] predicates;
	public ConfigAbilityPredicate[] predicatesForeach;
	public virtual async Task Invoke(string abilityName, BaseEntity srcEntity, SceneEntity? targetEntity = null)
	{

	}
}
