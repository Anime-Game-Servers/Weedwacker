using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioGeneral
{
	public ConfigWwiseString pauseGameObjectEvent;
	public ConfigWwiseString resumeGameObjectEvent;
	public ConfigWwiseString pauseBusEvent;
	public ConfigWwiseString resumeBusEvent;
	public ConfigWwiseString stopAllEvent;
	public uint[] permanentSoundBanks;
	public Dictionary<string, uint[]> platformPermanentBanks;
}