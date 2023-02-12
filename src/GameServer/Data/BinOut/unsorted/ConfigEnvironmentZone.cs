using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigEnvironmentZone
{
	public uint areaId;
	public EnvironmentType envType;
	public Point2D[] pointVec;
	public float bottom;
	public float top;
	public bool isUseHeightRange;
	public uint animalMaxNum;
	public uint refreshTime;
	public uint index;
	public EnvZoneEventType[] eventTypeList;
	public uint taskContentType;
	public RandTaskContentType taskType;
	public uint[] taskIdList;
	public Point2D center;
	public uint level;
	public uint zoneBitType;
	public bool choosePossiblePoint;
	public Vector[] possiblePointVec;
	public uint[] randomQuestEntranceIdList;
}