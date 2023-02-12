using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueGadgetExcelConfig
{
	public uint id;
	public RogueCreateGadgetType gadgetType;
	public uint gadgetId;
	public RogueGadgetStateConfig[] gadgetStateConfigList;

	public class RogueGadgetStateConfig
	{
		public RogueGadgetStateType state;
		public uint gadgetState;
	}
}