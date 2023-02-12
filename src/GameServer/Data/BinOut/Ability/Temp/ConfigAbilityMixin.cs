using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp;

public class ConfigAbilityMixin : BaseActionContainer, IInvocation
{
	public bool isUnique;
	public virtual async Task Invoke(string abilityName, BaseEntity srcEntity, SceneEntity? targetEntity = null)
	{
	}

	public virtual async Task Initialize(LocalIdGenerator idGenerator, IDictionary<uint, IInvocation> localIdToInvocationMap)
	{
		await Task.Yield();
		localID = idGenerator.GetLocalId();
		localIdToInvocationMap[localID] = this;
		/*
		idGenerator.ConfigIndex = 0;
		for(BaseAction[] actions in BaseAction[][] containrer)
		{
			for(BaseAction action)
			{
				idGenerator.InitializeActionLocalIds
			}
			idGenerator.ConfigIndex++;
		}
		idGenerator.ConfigIndex = 0;
		*/
	}
}
