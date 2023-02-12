using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetPaimonTempOffset : ConfigAbilityAction
{
	public PaimonRequestFrom from;
	public Vector offSetPos;
	public float time;
}
