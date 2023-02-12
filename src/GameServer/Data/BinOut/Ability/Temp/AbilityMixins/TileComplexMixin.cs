using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TileComplexMixin : ConfigAbilityMixin
{
	public string attackID;
	public string attachPointName;
	public Vector offset;
	public TileShapeInfo shape;
}
