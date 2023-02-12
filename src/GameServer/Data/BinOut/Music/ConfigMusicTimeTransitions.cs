using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMusicTimeTransitions
{
	public float interval;
	public ConfigMusicTransitions repetitives;
	public ConfigMusicFixedTimeTransitions[] fixedTimes;
}