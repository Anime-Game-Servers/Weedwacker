using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIPrecombatSetting
{
	public float bioClockSleepFrom;
	public float bioClockSleepTo;
	public float satietyTime;
	public Dictionary<ConfigWeatherType, NeuronName[]> overrideWeatherNeuronMapping;
}