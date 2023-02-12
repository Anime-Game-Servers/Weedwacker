using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Coop;

public class ConfigCoopSelectNode : ConfigCoopBaseNode
{
	public CoopSelectNodeContent[] selectList;
	public bool delayMoveNext;

	public class CoopSelectNodeContent
	{
		public uint dialogId;
		public CoopCondGroup showCond;
		public CoopCondGroup enableCond;
	}
}