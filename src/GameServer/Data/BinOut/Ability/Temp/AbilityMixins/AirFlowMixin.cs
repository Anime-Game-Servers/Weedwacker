using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AirFlowMixin : ConfigAbilityMixin
{
	public uint gadgetID;
	public uint campID;
	public TargetType campTargetType;
	public ConfigBornType born;
}
