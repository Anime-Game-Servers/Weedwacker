using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ShowScreenEffect : ConfigAbilityAction
{
	public EffectType effectType;
	public bool show;
}
