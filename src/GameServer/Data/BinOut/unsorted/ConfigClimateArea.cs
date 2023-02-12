using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigClimateArea
{
	public uint area_id;
	public JsonClimateType climateType;
	public float bottom;
	public float top;
	public Point2D[] points;
	public bool isForceClearDifferentClimateMeter;
	public uint[] transPoints;
}