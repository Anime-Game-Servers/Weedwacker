using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes;

public class ConfigBornByGlobalValue : ConfigBornType
{
	public string positionKey;
	public string directionKey;
	public bool useGlobalUp;
}
