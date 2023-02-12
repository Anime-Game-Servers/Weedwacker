using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("FetterStoryExcelConfigData.json")]
public class FetterStoryData : FetterConfig
{
	public bool isHiden;
	public uint storyTitleTextMapHash;
	public uint storyContextTextMapHash;
	public uint storyTitle2TextMapHash;
	public uint storyContext2TextMapHash;
	public uint[] tips;
	public uint storyTitleLockedTextMapHash;
}
