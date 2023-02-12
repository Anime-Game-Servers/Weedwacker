using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttachAbilityStateResistance : ConfigAbilityAction
{
	public uint resistanceListID;
	public AbilityState[] resistanceBuffDebuffs;
	public float durationRatio;
}
