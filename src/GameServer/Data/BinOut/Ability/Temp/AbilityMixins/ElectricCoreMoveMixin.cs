using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ElectricCoreMoveMixin : ConfigAbilityMixin
{
	public float stageOnceVelocity;
	public float stageOneAccelerate;
	public float stageTwoVelocity;
	public float stageTwoAttenuation;
	public float maxAbsorbTime;
	public ConfigBornType toPos;
	public ConfigAbilityAction[] onCoreEnter;
	public ConfigAbilityAction[] onInterrupted;
	public ConfigAbilityAction[] onStartSuccess;
	public ConfigAbilityAction[] onStartFailed;
}
