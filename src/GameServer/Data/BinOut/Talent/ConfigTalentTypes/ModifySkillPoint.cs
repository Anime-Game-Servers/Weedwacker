using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifySkillPoint : ConfigTalentMixin
    {
		public uint skillID;
		public int pointDelta;
	}
}
