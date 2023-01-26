using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UgcAxialType
    {
        X,
        Y,
        Z
    }
}
