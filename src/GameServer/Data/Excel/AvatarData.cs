using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarExcelConfigData.json")]
public class AvatarData : CreatureExcelConfig
{
	public AvatarUseType useType;
	public BodyType bodyType;
	public byte scriptDataPathHashPre;
	public uint scriptDataPathHashSuffix;
	public string iconName;
	public string sideIconName;
	public QualityType qualityType;
	public float chargeEfficiency;
	public float healAdd;
	public float healedAdd;
	public byte combatConfigHashPre;
	public uint combatConfigHashSuffix;
	public bool isRangeAttack;
	public uint initialWeapon;
	public WeaponType weaponType;
	public byte manekinPathHashPre;
	public uint manekinPathHashSuffix;
	public string imageName;
	public byte gachaCardNameHashPre;
	public uint gachaCardNameHashSuffix;
	public byte gachaImageNameHashPre;
	public uint gachaImageNameHashSuffix;
	public byte coopPicNameHashPre;
	public uint coopPicNameHashSuffix;
	public string cutsceneShow;
	public uint skillDepotId;
	public float staminaRecoverSpeed;
	public uint[] candSkillDepotIds;
	public byte manekinJsonConfigHashPre;
	public uint manekinJsonConfigHashSuffix;
	public uint manekinMotionConfig;
	public uint descTextMapHash;
	public AvatarIdentityType avatarIdentityType;
	public uint avatarPromoteId;
	public uint[] avatarPromoteRewardLevelList;
	public uint[] avatarPromoteRewardIdList;
	public uint featureTagGroupID;
	public uint infoDescTextMapHash;
	public byte animatorConfigPathHashPre;
	public uint animatorConfigPathHashSuffix;
}
