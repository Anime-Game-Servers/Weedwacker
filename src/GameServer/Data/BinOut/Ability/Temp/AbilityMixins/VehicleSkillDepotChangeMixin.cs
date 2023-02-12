using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class VehicleSkillDepotChangeMixin : ConfigAbilityMixin
{
	public uint[] targetVehicleIDs;
	public uint skillDepotId;
}