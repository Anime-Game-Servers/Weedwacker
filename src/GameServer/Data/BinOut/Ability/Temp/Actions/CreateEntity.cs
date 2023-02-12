using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class CreateEntity : ConfigAbilityAction
{
	public bool ownerIsTarget;
	public AbilityTargetting ownerIs;
	public AbilityTargetting propOwnerIs;
	public bool lifeByOwnerIsAlive;
	public ConfigBornType born;
	public CheckGround checkGround;
	public bool sightGroupWithOwner;
	public bool isPeerIdFromPlayer;
	public bool lifeByOwnerV2;
	public bool dontKillSelfByClientPrediction;

	public class CheckGround
	{
		public bool enable;
		public float raycastUpHeight;
		public float raycastDownHeight;
		public bool stickToGroundIfValid;
		public bool dontCreateIfInvalid;
	}
}