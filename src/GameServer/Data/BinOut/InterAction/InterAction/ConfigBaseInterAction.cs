using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBaseInterAction
{
	public InteractionType type;
	public float delayTime;
	public float duration;
	public string[] aliasList;
	public bool checkNextImmediately;
	public uint actionId;
	public uint preActionId;
	public bool haveNextAction;
}