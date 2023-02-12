using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueDiaryBuffDataExcelConfig
{
	public uint id;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public string[] descParam;
	public uint quality;
	public string icon;
	public RogueDiaryBuffType type;
	public RogueDiaryBuffEffectType effectType;
}