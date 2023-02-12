using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class EntityDoSkill : ConfigAbilityAction
{
	public uint skillID;
	public bool isHold;
}
