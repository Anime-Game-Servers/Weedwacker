
namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class EntityDefenceMixin : ConfigAbilityMixin
{
	public string[] stateIDs;
	public string defendTriggerID;
	public float defendAngle;
	public object defendProbability;
	public object defendProbabilityDelta;
	public object defendTimeInterval;
	public bool alwaysRecover;
	public object defendCountInterval;
	public bool canDefenceWhileEndureFull;
}