using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ChangeEnviroWeather : ConfigAbilityAction
{
	public uint areaId;
	public uint climateType;
	public float transDuration;
}
