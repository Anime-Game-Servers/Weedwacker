using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioSurfaceType
{
	public ConfigWwiseString switchKey;
	public ConfigWwiseString tallGrassRtpcId;
	public ConfigWwiseString waterDepthRtpcId;
	public Dictionary<string, string> switchMap;
	public Dictionary<string, string> rtpcMap;
}