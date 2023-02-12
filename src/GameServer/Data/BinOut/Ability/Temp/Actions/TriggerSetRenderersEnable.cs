using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerSetRenderersEnable : ConfigAbilityAction
{
	public string[] renderNames;
	public bool setEnable;
}
