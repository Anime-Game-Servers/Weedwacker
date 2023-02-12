using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TileAttackManagerMixin : ConfigAbilityMixin
{
	public string attackID;
	public float interval;
	public TileCampType campType;
	public uint fixCamp;
	public bool authorityHandle;
	public ConfigAttackInfo attackInfo;
}
