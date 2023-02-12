using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSpeechBubbleAction : ConfigBaseInterAction
{
	public uint dialogID;
	public uint priority;
	public bool holdOn;
	public bool tryStop;
}