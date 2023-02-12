using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class SwitchSkillIDMixin : ConfigAbilityMixin
{
	public SwitchSkillPriority priority;
	public int skillIndex;
	public uint skillID;
	public uint fromSkillID;
	public uint toSkillID;
}
