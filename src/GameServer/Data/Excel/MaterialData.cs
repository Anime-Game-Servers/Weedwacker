using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("MaterialExcelConfigData.json")]
public class MaterialData : ItemConfig
{
	public uint interactionTitleTextMapHash;
	public MaterialType materialType;
	public uint cdTime;
	public uint cdGroup;
	public uint stackLimit;
	public uint maxUseCount;
	public bool useOnGain;
	public bool noFirstGetHint;
	public bool playGainEffect;
	public ItemUseTarget useTarget;
	public ItemUseConfig[] itemUse;
	public uint rankLevel;
	public FoodQualityType foodQuality;
	public uint effectDescTextMapHash;
	public uint specialDescTextMapHash;
	public uint typeDescTextMapHash;
	public string effectIcon;
	public uint effectGadgetID;
	public string effectName;
	public string[] picPath;
	public bool isSplitDrop;
	public bool closeBagAfterUsed;
	public uint[] satiationParams;
	public MaterialDestroyType destroyRule;
	public uint[] destroyReturnMaterial;
	public uint[] destroyReturnMaterialCount;
	public uint setID;
	public bool isHidden;
	public bool isForceGetHint;

	public class ItemUseConfig
	{
		public ItemUseOp useOp;
		public string[] useParam;
	}
}
