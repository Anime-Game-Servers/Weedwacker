using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class SkillButtonHoldChargeMixin : ConfigAbilityMixin
{
	public bool allowHoldLockDirection;
	public uint skillID;
	public string nextLoopTriggerID;
	public string endHoldTrigger;
	public string[] beforeStateIDs;
	public float beforeHoldDuration;
	public string[] chargeLoopStateIDs;
	public string[] afterStateIDs;
	public float[] chargeLoopDurations;
	public string[] transientStateIDs;
}
