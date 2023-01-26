using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TowerType
    {
        None,
        Simple,
        Mine,
        Electric,
        Fire,
        Ice,
        Water,
        Wind,
    }
}
