using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TowerLevelExcelConfig
{
	public uint levelId;
	public uint levelGroupId;
	public uint levelIndex;
	public uint dungeonId;
	public TowerCondition[] conds;
	public string[] towerBuffConfigStrList;
	public uint dailyRewardId;
	public uint firstPassRewardId;
	public uint monsterLevel;
	public uint[] firstMonsterList;
	public uint[] secondMonsterList;

	public class TowerCondition
	{
		public TowerCondType towerCondType;
		public uint[] argumentListUpper;
		public uint[] argumentList;
	}
}