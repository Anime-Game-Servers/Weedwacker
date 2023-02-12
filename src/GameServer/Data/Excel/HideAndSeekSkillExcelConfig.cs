using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HideAndSeekSkillExcelConfig
{
	public uint id;
	public uint challengeID;
	public uint skillID;
	public uint order;
	public HIDE_AND_SEEK_SKILL_CATEGORY skillCategory;
	public HIDE_AND_SEEK_SKILL_SUB_CATEGORY skillSubCategory;
	public bool isDefault;
	public uint categoryDescTextMapHash;
	public byte skillIconPathHashPre;
	public uint skillIconPathHashSuffix;
}