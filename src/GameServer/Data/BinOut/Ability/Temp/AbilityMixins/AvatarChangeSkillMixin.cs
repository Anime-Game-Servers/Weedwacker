using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AvatarChangeSkillMixin : ConfigAbilityMixin
{
	public int index;
	public SwitchSkillPriority priority;
	public uint aimSkillID;
	public uint jumpSkillID;
	public uint flySkillID;
	public bool changeOnAdd;
}
