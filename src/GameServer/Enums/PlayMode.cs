using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayMode
	{
		PLAY_MODE_ALL,
		PLAY_MODE_SINGLE,
		PLAY_MODE_MULTIPLE,
		PLAY_MODE_HOST,
		PLAY_MODE_GUEST,
	}
}
