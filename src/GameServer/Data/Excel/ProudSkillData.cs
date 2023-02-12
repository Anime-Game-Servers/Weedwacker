using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ProudSkillExcelConfigData.json")]
public class ProudSkillData : BaseTalentConfig
{
	public uint proudSkillId;
	public uint proudSkillGroupId;
	public uint level;
	public uint proudSkillType;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public uint unlockDescTextMapHash;
	public string icon;
	public uint coinCost;
	public IdCountConfig[] costItems;
	public TalentFilterCond[] filterConds;
	public uint breakLevel;
	public uint[] paramDescList;
	public ProudLifeEffectType lifeEffectType;
	public string[] lifeEffectParams;
	public byte effectiveForTeam;
	public bool isHideLifeProudSkill;

	public List<IdCountConfig> GetTotalCostItems()
	{
		List<IdCountConfig> total = new();
		total = (List<IdCountConfig>)total.Concat(costItems);
		if (coinCost > 0)
			total.Add(new IdCountConfig(202, coinCost));

		return total;
	}
}
