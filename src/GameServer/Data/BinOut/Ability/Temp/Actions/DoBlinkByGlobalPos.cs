using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class DoBlinkByGlobalPos : ConfigAbilityAction
{
	public string positionKey;
	public string directionKey;
	public bool useGlobalUp;
}
