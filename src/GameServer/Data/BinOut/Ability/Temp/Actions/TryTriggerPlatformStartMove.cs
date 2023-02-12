using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TryTriggerPlatformStartMove : ConfigAbilityAction
{
	public float detectHeight;
	public float detectWidth;
	public bool enableRotationOffset;
	public ConfigAbilityAction[] failActions;
	public bool forceReset;
	public bool forceTrigger;
}
