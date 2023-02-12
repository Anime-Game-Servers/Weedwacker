using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("MonsterExcelConfigData.json")]
public class MonsterExcelConfig : CreatureExcelConfig
{
	public string monsterName;
	public MonsterType type;
	public MonsterSecurityLevel securityLevel;
	public byte scriptDataPathHashPre;
	public uint scriptDataPathHashSuffix;
	public string serverScript;
	public byte combatConfigHashPre;
	public uint combatConfigHashSuffix;
	public uint[] affix;
	public string ai;
	public bool isAIHashCheck;
	public uint[] equips;
	public bool canSwim;
	public MonsterDrop[] hpDrops;
	public uint killDropId;
	public bool isSceneReward;
	public VisionLevelType visionLevel;
	public bool isInvisibleReset;
	public string excludeWeathers;
	public uint featureTagGroupID;
	public uint mpPropID;
	public string skin;
	public uint describeId;
	public bool safetyCheck;
	public int combatBGMLevel;
	public int entityBudgetLevel;

	public class MonsterDrop
	{
		public uint dropId;
		public float hpPercent;
	}
}