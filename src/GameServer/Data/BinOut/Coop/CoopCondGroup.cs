using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Coop;

public class CoopCondGroup
{
	public LogicType condCombType;
	public CoopCond[] coopCondList;

	public class CoopCond
	{
		public CoopCondType type;
		public int[] param;
	}
}
