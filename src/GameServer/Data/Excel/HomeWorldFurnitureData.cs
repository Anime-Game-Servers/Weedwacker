using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("HomeWorldFurnitureExcelConfigData.json")]
public class HomeWorldFurnitureData : ItemConfig
{
	public uint[] furnitureGadgetID;
	public uint[] furnType;
	public FurnitureDeploySurfaceType surfaceType;
	public uint arrangeLimit;
	public uint isSpecialFurniture;
	public SpeicalFurnitureType specialFurnitureType;
	public uint roomSceneID;
	public uint gridStyle;
	public uint comfort;
	public uint stackLimit;
	public uint cost;
	public uint discountCost;
	public uint isCombinableLight;
	public float height;
	public uint canFloat;
	public uint isUnique;
	public string itemIcon;
	public string effectIcon;
	public float clampDistance;
	public float editorClampDistance;
	public uint deployGlitchIndex;
	public uint rankLevel;
	public string jsonName;
	public uint pushTipsId;
	public GroupRecordType groupRecordType;
}
