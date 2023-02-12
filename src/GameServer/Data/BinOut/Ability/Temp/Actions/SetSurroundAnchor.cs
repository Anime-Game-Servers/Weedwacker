using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetSurroundAnchor : ConfigAbilityAction
{
	public bool setPoint;
	public ActionPointType actionPointType;
	public uint actionPointID;
}
