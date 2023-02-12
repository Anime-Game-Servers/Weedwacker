using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWeatherArea
{
	public uint area_id;
	public bool isAccurateBorder;
	public Point2D[] points;
	public bool isUseHeightBorder;
	public float bottom;
	public float top;
}