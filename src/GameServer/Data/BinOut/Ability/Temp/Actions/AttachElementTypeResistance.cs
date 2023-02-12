using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttachElementTypeResistance : ConfigAbilityAction
{
	public ElementType elementType;
	public float durationRatio;
}
