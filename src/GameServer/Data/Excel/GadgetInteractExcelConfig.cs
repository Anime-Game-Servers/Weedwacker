using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GadgetInteractExcelConfig
{
	public uint interactId;
	public InteractActionType actionType;
	public uint param1;
	public uint param2;
	public GadgetInteractActionConfig[] actionList;
	public bool isGuestInteract;
	public IdCountConfig[] costItems;
	public uint uiTitleTextMapHash;
	public uint uiDescTextMapHash;
	public GadgetInteractCond[] condList;
	public LogicType condComb;
	public bool isMpModeInteract;

	public class GadgetInteractActionConfig
	{
		public InteractActionType actionType;
		public uint[] param;
	}
	public class GadgetInteractCond
	{
		public InteractCondType condType;
		public string[] param;
	}
}