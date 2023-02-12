using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class EnableRocketJump : ConfigAbilityAction
{
	public RocketJumpType type;
	public bool enable;
	public RocketJumpExt extention;
	public bool uiEffect;
}
