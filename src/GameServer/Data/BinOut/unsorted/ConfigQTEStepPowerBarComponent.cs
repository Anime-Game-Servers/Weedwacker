using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigQTEStepPowerBarComponent : ConfigQTEStepBaseComponent
{
	public uint initValue;
	public uint maxValue;
	public float autoChangeValuePerSecond;
	public float noInputAutoChangeInterval;
	public ConfigQTEStepCondActionGroup[] valueChangeTrigger;
}