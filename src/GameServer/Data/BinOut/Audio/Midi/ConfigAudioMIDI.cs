using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioMIDI
{
	public Dictionary<int, Dictionary<int, ConfigWwiseString>> instruments;
	public Dictionary<int, int> freeplay_buttons;
	public float freeplay_timeout;
	public float freeplay_max_distance;
}