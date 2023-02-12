using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarSkillDepotExcelConfigData.json")]
public class AvatarSkillDepotData
{
	public uint id;
	public uint energySkill;
	public uint talentSkill;
	public uint[] skills;
	public uint[] subSkills;
	public uint attackModeSkill;
	public uint leaderTalent;
	public string[] extraAbilities;
	public uint[] talents;
	public string? talentStarName;
	public uint coreProudSkillGroupId;
	public uint coreProudAvatarPromoteLevel;
	public ProudSkillOpenConfig[] inherentProudSkillOpens;
	public string? skillDepotAbilityGroup;

	public class ProudSkillOpenConfig
	{
		public uint proudSkillGroupId;
		public uint needAvatarPromoteLevel;
	}
}
