using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityCrystalLinkLevelExcelConfig
{
	public uint levelId;
	public uint scheduleId;
	public uint openDay;
	public uint dungeonId;
	public uint[] trialAvatarList;
	public uint[] watcherIdList;
	public uint[] condBuffIdList;
	public uint[] effectBuffIdList;
	public uint levelTitleTextMapHash;
	public uint levelDescTextMapHash;
	public MonsterConfig[] monsterConfigArray;
	public MainMonsterConfig[] mainMonsterConfigArray;
	public uint[] scoreLevelList;
	public uint condCD;
	public uint effLastTime;

	public class MainMonsterConfig
	{
		public uint[] boss;
		public uint[] monster;
	}
}