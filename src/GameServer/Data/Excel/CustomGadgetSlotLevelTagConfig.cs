using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CustomGadgetSlotLevelTagConfig
{
	public uint ID;
	public CustomGadgetRootType customGadgetType;
	public CustomGadgetSlotGroup[] slotMap;
	public uint levelTagID;
	public uint GadgetId;

	public class CustomGadgetSlotGroup
	{
		public string slotIdentifier;
		public uint[] slotList;
	}
}