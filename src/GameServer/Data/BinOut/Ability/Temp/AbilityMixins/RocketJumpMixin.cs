using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class RocketJumpMixin : ConfigAbilityMixin
{
	public RocketJumpType type;
	public RocketJumpExt extention;
	public bool uiEffect;

}
