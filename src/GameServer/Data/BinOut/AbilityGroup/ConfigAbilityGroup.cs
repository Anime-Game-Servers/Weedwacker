using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.AbilityGroup
{
    internal class ConfigAbilityGroup
    {
		public AbilityGroupSourceType abilityGroupSourceType;
		public AbilityGroupTargetType abilityGroupTargetType;
		public uint[] abilityGroupTargetIDList;
		public ConfigEntityAbilityEntry[] targetAbilities;
		public ConfigDynamicTalent[] targetTalents;

		public class ConfigDynamicTalent
		{
			public string talentName;
		}
	}
}
