using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerBullet : ConfigAbilityAction
{
	public uint bulletID;
	public ConfigBornType born;
	public bool ownerIsTarget;
	public AbilityTargetting ownerIs;
	public AbilityTargetting propOwnerIs;
	public bool lifeByOwnerIsAlive;
	public AbilityTargetting trackTarget;
	public SingleTarget[] trackTargetList;
	public bool sightGroupWithOwner;
	public bool isPeerIdFromPlayer;
	public bool lifeByOwnerV2;
	public bool dontKillSelfByClientPrediction;

	public class SingleTarget
	{
		public AbilityTargetting target;
		public SelectTargets otherTargets;
		public ConfigAbilityPredicate[] targetPredicates;
	}
}
