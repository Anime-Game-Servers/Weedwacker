using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBodyLangInterAction : ConfigBaseInterAction
{
	public bool isContinue;
	public int bodyLangParam;
	public int loopState;
	public bool forceInterrupt;
	public int[] randomParamList;
	public bool forceDoFreeStyle;
	public bool canDoRepeatFreeStyle;
	public bool dontClearPreFreeStyle;
}