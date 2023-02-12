using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetPaimonLookAtCamera : ConfigAbilityAction
{
	public PaimonRequestFrom from;
	public bool lookat;
	public float minTime;
	public float maxTime;
}
