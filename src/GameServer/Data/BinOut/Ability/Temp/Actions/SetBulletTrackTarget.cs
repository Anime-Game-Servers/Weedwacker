
using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetBulletTrackTarget : ConfigAbilityAction
{
	public bool notDoIfTrackTargetAlive;
}
