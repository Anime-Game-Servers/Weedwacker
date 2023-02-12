using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("FetterInfoExcelConfigData.json")]
public class FetterInfoData : FetterConfig
{
	public bool isHiden;
	public uint infoBirthMonth;
	public uint infoBirthDay;
	public uint avatarNativeTextMapHash;
	public uint avatarVisionBeforTextMapHash;
	public uint avatarConstellationBeforTextMapHash;
	public uint avatarTitleTextMapHash;
	public uint avatarDetailTextMapHash;
	public AssocType avatarAssocType;
	public uint cvChineseTextMapHash;
	public uint cvJapaneseTextMapHash;
	public uint cvEnglishTextMapHash;
	public uint cvKoreanTextMapHash;
	public uint avatarVisionAfterTextMapHash;
	public uint avatarConstellationAfterTextMapHash;
}
