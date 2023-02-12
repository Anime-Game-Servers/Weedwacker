using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("PhotographExpressionExcelConfigData.json")]
public class PhotographExpressionData : FetterConfig
{
	public string emotionName;
	public string phonemeName;
	public string icon;
	public uint emotionDescriptionTextMapHash;
	public uint unlockDescTextMapHash;
}
