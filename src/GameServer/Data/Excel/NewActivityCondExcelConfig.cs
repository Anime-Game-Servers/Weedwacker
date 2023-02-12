using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NewActivityCondExcelConfig
{
	public uint condId;
	public LogicType condComb;
	public NewActivityCond[] cond;

	public class NewActivityCond
	{
		public NewActivityCondType type;
		public int[] param;
	}
}