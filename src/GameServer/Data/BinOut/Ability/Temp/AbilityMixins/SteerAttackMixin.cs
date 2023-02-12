using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class SteerAttackMixin : ConfigAbilityMixin
{
	public string[] steerStateIDs;
	public float startNormalizedTime;
	public float endNormalizedTime;
	public float angularSpeed;
	public float attackAngle;
	public string attackTrigger;
	public float attackDistance;
	public bool remoteSteerToLocalTarget;
	public SteerAttackTargetType[] facingTargetTypes;
}
