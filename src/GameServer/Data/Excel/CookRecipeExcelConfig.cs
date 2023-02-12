using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CookRecipeExcelConfig
{
	public uint id;
	public uint nameTextMapHash;
	public uint rankLevel;
	public string icon;
	public uint descTextMapHash;
	public uint[] effectDesc;
	public CookFoodType foodType;
	public CookMethodType cookMethod;
	public bool isDefaultUnlocked;
	public uint maxProficiency;
	public IdCountConfig[] qualityOutputVec;
	public IdCountConfig[] inputVec;
	public string qteParam;
	public uint[] qteQualityWeightVec;
}