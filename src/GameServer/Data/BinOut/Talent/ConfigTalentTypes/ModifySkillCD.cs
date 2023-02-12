using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifySkillCD : ConfigTalentMixin
    {
		public uint skillID;
		public float cdDelta;
		public float cdRatio;

		public override void Apply(BaseAbilityManager abilityManager, float[] paramList)
        {
            //TODO
        }
    }
}
