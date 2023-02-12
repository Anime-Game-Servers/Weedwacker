using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioGameViewState
{
	public ConfigWwiseString stateGroupName;
	public ConfigWwiseString normalStateValue;
	public ConfigWwiseString focusedStateValue;
	public ConfigWwiseString sneakInStateValue;
	public ConfigWwiseString menuStateValue;
	public ConfigWwiseString pauseMenuStateValue;
	public ConfigWwiseString dialogStateValue;
	public ConfigWwiseString videoStateValue;
	public ConfigWwiseString elementViewStateValue;
	public ConfigWwiseString musicGameSoloStateValue;
	public ConfigWwiseString musicGameFreePlayStateValue;
	public string[] uiPageIgnoreList;
}