using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CombineExcelConfig
{
	public uint combineId;
	public uint playerLevel;
	public bool isDefaultShow;
	public uint combineType;
	public uint subCombineType;
	public uint resultItemId;
	public uint resultItemCount;
	public uint scoinCost;
	public RandomItemConfig[] randomItems;
	public IdCountConfig[] materialItems;
	public uint effectDescTextMapHash;
	public RecipeType recipeType;
}