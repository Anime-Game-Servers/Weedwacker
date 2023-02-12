using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ResistClimateMixin : ConfigAbilityMixin
{
	public JsonClimateType[] climateTypes;
	public ClimateSourceType source;
	public ClimateTrendType trend;
	public object ratio;
	public AvatarStageType type;
}
