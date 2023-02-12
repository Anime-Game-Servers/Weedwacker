using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCutsceneInterAction : ConfigBaseInterAction
{
	public ConfigBaseCutscene cutsceneCfg;
	public uint cutsceneIndex;
	public bool syncLoad;
}