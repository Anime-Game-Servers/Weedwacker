using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class PlayerUidNotifyMixin : ConfigAbilityMixin
{
	public string opParam;
	public uint opType;
	public RelationalOperator logic;
	public ConfigAbilityAction[] actions;
}
