using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSong
{
	public int id;
	public ConfigWwiseString switchValue;
	public ConfigMusicSyncTransitions syncTransitions;
	public ConfigMusicTimeTransitions timeTransitions;
	public ConfigMusicStimulusHandler[] stimulusHandlers;
	public int ignoranceMask;
}