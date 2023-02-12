using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ReviveElemEnergyMixin : ConfigAbilityMixin
{
	public AvatarStageType type;
	public object period;
	public object baseEnergy;
	public object ratio;
}
