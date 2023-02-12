using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("WeaponExcelConfigData.json")]
public class WeaponData : ItemConfig
{
	public WeaponType weaponType;
	public uint rankLevel;
	public WeaponMaterialType materialType;
	public ElementType elemType;
	public bool isGold;
	public uint weaponBaseExp;
	public uint[] skillAffix;
	public uint awakenMaterial;
	public WeaponProperty[] weaponProp;
	public string awakenTexture;
	public string awakenLightMapTexture;
	public string awakenIcon;
	public bool unRotate;
	public uint weaponPromoteId;
	public uint storyId;
	public uint[] awakenCosts;
	public byte gachaCardNameHashPre;
	public uint gachaCardNameHashSuffix;
	public uint enhanceRule;
	public MaterialDestroyType destroyRule;
	public uint[] destroyReturnMaterial;
	public uint[] destroyReturnMaterialCount;
	public uint initialLockState;

	public class WeaponProperty
	{
		public FightPropType propType;
		public float initValue;
		public GrowCurveType type;
	}
}
