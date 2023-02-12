using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class RemoveVelocityForce : ConfigAbilityAction
{
	public VelocityForceType[] forces;
}
