using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class UseItem : ConfigAbilityAction
{
	public uint itemId;
	public uint itemNum;
}
