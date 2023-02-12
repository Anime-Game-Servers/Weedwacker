using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigGadgetUIBase
{
	public string gadgetUIBtnCfgPath;
	public string uiName;
	public TouchInteractType onTouch;
	public string[] touchParams;
	public LogicType showCombType;
	public GadgetUIItemShowCondType[] showCondTypes;
	public float[] postGadgetActionParams;
	public string icon;
	public string groupName;
	public GadgetInteractItemType itemType;
	public bool needDialogConfirm;
	public string confirmDialogTitle;
	public string confirmDialogContent;
}