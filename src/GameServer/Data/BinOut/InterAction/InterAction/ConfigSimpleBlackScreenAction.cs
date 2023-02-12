using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSimpleBlackScreenAction : ConfigBaseInterAction
{
	public float durationToBlack;
	public float durationKeepBlack;
	public float durationFromBlack;
	public string textMapID;
	public bool useWhiteScreen;
	public bool useTextFade;
	public uint dialogID;
	public bool disableResAsyncLoad;
}