using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerSetShadowRamp : ConfigAbilityAction
{
	public bool useShadowRamp;
	public string[] specialMats;
}
