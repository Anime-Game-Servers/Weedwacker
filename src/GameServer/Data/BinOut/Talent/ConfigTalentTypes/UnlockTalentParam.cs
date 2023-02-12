using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class UnlockTalentParam : ConfigTalentMixin
    {
        public string abilityName;
        public string talentParam;

        public override void Apply(BaseAbilityManager abilityManager, float[] paramList)
        {
            if (abilityManager.UnlockedTalentParams.ContainsKey(abilityName))
                abilityManager.UnlockedTalentParams[abilityName].Add(talentParam);
            else
            {
                abilityManager.UnlockedTalentParams[abilityName] = new() { talentParam };
            }
        }
    }
}
