using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class ConfigLocalTrigger : ConfigLocalEntity
{
	public TriggerFlag triggerFlag;
	public ConfigBaseShape shape;
	public short checkCount;
	public float triggerInterval;
	public Vector vectorParam;
	public float floatParam;
	public string stringParam;
}