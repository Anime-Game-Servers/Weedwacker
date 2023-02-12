using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TileComplexManagerMixin : ConfigAbilityMixin
{
	public string attackID;
	public float interval;
	public uint srcCamp;
	public ConfigAttackInfo attackInfo;
}
