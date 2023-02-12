using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TriggerWeatherMixin : ConfigAbilityMixin
{
	public TriggerWeatherType type;
	public uint areaId;
	public string weatherPattern;
	public float transDuration;
	public float duration;
}
