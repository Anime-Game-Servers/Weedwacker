using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("FettersExcelConfigData.json")]
public class FettersData : FetterConfig
{
	public uint type;
	public bool isHiden;
	public uint[] hideCostumeList;
	public uint[] showCostumeList;
	public uint[] tips;
	public uint voice_titleTextMapHash;
	public string voice_file;
	public uint voice_file_textTextMapHash;
	public uint voice_title_lockedTextMapHash;
}
