using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMusic
{
	public ConfigWwiseString switchGroup;
	public ConfigWwiseString playEvent;
	public ConfigWwiseString stopEvent;
	public ConfigWwiseString pauseEvent;
	public ConfigWwiseString resumeEvent;
	public ConfigWwiseString duckEvent;
	public ConfigWwiseString unduckEvent;
	public ConfigMusicTransitions startTransitions;
	public ConfigMusicSyncTransitions syncTransitions;
	public ConfigMusicTimeTransitions timeTransitions;
	public ConfigMusicStimulusHandler[] stimulusHandlers;
}