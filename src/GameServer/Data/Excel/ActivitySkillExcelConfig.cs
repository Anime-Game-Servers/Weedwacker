using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivitySkillExcelConfig
{
	public uint id;
	public ActivitySkillTarget skillTarget;
	public string abilityName;
	public string globalValueKey;
	public uint energyMin;
	public uint energyMax;
	public float cdTime;
	public float guideTime;
	public string skillIcon;
	public string[] guideKey;
	public OpenStateType guideOpenState;
	public uint unableTextTextMapHash;
	public uint channelTextTextMapHash;
	public uint interruptTextTextMapHash;
}