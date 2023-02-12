using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("WeatherExcelConfigData.json")]
public class WeatherData
{
	public uint areaID;
	public uint weatherAreaId;
	public string maxHeightStr;
	public uint gadgetID;
	public bool isDefaultValid;
	public string templateName;
	public uint priority;
	public string profileName;
	public ClimateType defaultClimate;
	public bool isUseDefault;
	public uint sceneID;
}
