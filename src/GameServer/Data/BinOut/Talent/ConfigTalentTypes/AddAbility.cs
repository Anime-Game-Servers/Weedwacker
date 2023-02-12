using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;

namespace Weedwacker.GameServer.Data.BinOut.Talent;

internal class AddAbility : ConfigTalentMixin
{
    public string abilityName;

    public override void Apply(BaseAbilityManager abilityManager, float[] paramList)
    {
        abilityManager.ActiveDynamicAbilities.Add(abilityName);
    }
}
