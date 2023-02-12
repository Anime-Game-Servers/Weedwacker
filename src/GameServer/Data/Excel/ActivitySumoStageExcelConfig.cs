using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivitySumoStageExcelConfig
{
	public uint Id;
	public uint scheduldId;
	public uint openDay;
	public uint dungeonId;
	public uint[] watcherList;
	public uint[] trialAvatarPool;
	public uint[] skillPool;
	public uint[] specialSkillPool;
	public uint galleryId;
	public uint[] hintNewSkillVec;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public uint[] scoreRanks;
	public ActivitySumoMonsterPreview[] monsterPreviewVec;
	public SumoStageMonsterWaveType monsterWaveType;
	public uint[] primaryBossMonsterVec;
	public uint[] primaryNormalMonsterVec;

	public class ActivitySumoMonsterPreview
	{
		public string boss;
		public string normal;
	}
}