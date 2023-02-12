using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ShowUICombatBar : ConfigAbilityAction
{
	public bool show;
	public uint sortID;
	public bool changingSortID;
	public bool fore;
}
