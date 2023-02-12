using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RoguelikeCurseExcelConfig
{
	public uint level;
	public uint groupId;
	public uint curseNameTextMapHash;
	public uint descTextMapHash;
	public RoguelikeEffectExcelConfig effectConfig;
	public bool isDynamicShow;
	public bool isClearAtNextLevel;
	public float[] descParamList;
	public bool[] descParamSuperpositionList;
}