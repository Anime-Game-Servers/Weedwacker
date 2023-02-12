using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class FollowAttachPointEffectMixin : ConfigAbilityMixin
{
	public string modifierName;
	public FollowAttachOccupyPriority attachPriority;
	public bool refreshOnAvatarIn;
}
