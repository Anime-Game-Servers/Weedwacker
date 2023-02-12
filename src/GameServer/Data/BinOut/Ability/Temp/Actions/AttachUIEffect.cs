using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttachUIEffect : ConfigAbilityAction
{
	public string effectPattern;
	public ActionPanelEffectSlot effectSlot;
}
