using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WeatherTemplateExcelConfig
{
	public string templateName;
	public ClimateType weatherType;
	public float sunnyProb;
	public float cloudyProb;
	public float rainProb;
	public float thunderstormProb;
	public float snowProb;
	public float mistProb;
}