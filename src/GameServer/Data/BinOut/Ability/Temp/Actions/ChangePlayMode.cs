using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ChangePlayMode : ConfigAbilityAction
{
	public PlayModeType toPlayMode;
	public bool authorityOnly;
}
