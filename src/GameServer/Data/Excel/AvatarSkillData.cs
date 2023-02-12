using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarSkillExcelConfigData.json")]
public class AvatarSkillData
{
	public uint id;
	public uint nameTextMapHash;
	public string abilityName;
	public uint descTextMapHash;
	public string skillIcon;
	public bool isRanged;
	public float cdTime;
	public bool ignoreCDMinusRatio;
	public float costStamina;
	public ElementType costElemType;
	public float costElemVal;
	public int maxChargeNum;
	public int triggerID;
	public string lockShape;
	public float[] lockWeightParams;
	public bool isAttackCameraLock;
	public SkillDrag dragType;
	public bool showIconArrow;
	public MonitorType needMonitor;
	public bool defaultLocked;
	public string buffIcon;
	public uint proudSkillGroupId;
	public string globalValueKey; // when this is not empty, set the avatar's global's value to energyMin
	public float energyMin;
	public bool forceCanDoSkill;
	public uint cdSlot;
	public bool needStore;
	public uint shareCDID;
}
