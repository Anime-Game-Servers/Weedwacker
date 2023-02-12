using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioArea2DAmbience
{
	public string areaName;
	public Vector[] areaPoints;
	public float yZeroAnchor;
	public ConfigWwiseString areaGroupName;
	public bool enableHeightCheck;
	public float top;
	public float bottom;
	public bool isAmbience;
	public ConfigWwiseString[] enterEvents;
	public ConfigWwiseString[] leaveEvents;
	public bool isReverb;
	public ConfigWwiseString auxBusName;
	public int priority;
	public bool excludeOther;
	public bool enableChangeStates;
	public AudioStateOp[] enterStates;
	public AudioStateOp[] leaveStates;
}