using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigAttackInfo
{
	public string attackTag;
	public string attenuationTag;
	public string attenuationGroup;
	public ConfigAttackProperty attackProperty;
	public ConfigHitPattern hitPattern;
	public bool canHitHead;
	public ConfigHitPattern hitHeadPattern;
	public bool forceCameraShake;
	public ConfigCameraShake cameraShake;
	public ConfigBulletWane bulletWane;
	public CanBeModifiedBy canBeModifiedBy;

	public class ConfigBulletWane
	{
		public float waneDelay;
		public float damageWaneInterval;
		public float damageWaneRatio;
		public float damageWaneMinRatio;
		public float elementDurabilityWaneInterval;
		public float elementDurabilityWaneRatio;
		public float elementDurabilityWaneMinRatio;
		public float hitLevelWaneInterval;
		public HitLevel hitLevelWaneMin;
	}
	public class ConfigAttackProperty
	{
		public object damagePercentage;
		public object damagePercentageRatio;
		public ElementType elementType;
		public float elementRank;
		public object elementDurability;
		public bool overrideByWeapon;
		public bool ignoreAttackerProperty;
		public StrikeType strikeType;
		public float enBreak;
		public float enHeadBreak;
		public AttackType attackType;
		public object damageExtra;
		public object bonusCritical;
		public object bonusCriticalHurt;
		public bool ignoreLevelDiff;
		public bool trueDamage;
		public bool ignoreModifyDamage;
	}

	public class ConfigHitPattern
	{
		public string onHitEffectName;
		public HitLevel hitLevel;
		public object hitImpulseX;
		public object hitImpulseY;
		public string hitImpulseType;
		public ConfigHitImpulse overrideHitImpulse;
		public RetreatType retreatType;
		public float hitHaltTime;
		public float hitHaltTimeScale;
		public bool canBeDefenceHalt;
		public bool muteHitText;
		public bool recurring;
		public bool forceRetreat;

		public class ConfigHitImpulse
		{
			public HitLevel hitLevel;
			public object hitImpulseX;
			public object hitImpulseY;
		}
	}
}
