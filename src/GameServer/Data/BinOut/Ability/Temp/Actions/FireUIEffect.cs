using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class FireUIEffect : ConfigAbilityAction
{
	public string effectPattern;
	public ActionPanelEffectSlot effectSlot;
}
