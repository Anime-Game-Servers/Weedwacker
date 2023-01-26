using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BlossomChestShowType
    {
        BLOSSOM_CHEST_SHOWTYPE_BLOSSOM,
        BLOSSOM_CHEST_SHOWTYPE_NO_RESIN
    }
}
