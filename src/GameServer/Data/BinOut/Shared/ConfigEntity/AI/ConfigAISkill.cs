using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAISkill
{
	public string name;
	public ConfigAISkillType skillType;
	public ConfigAICombatSkillType combatSkillType;
	public int priority;
	public bool canUseCombatSkillCondition;
	public bool needLineOfSight;
	public bool faceTarget;
	public bool canUseIfTargetInactive;
	public bool enableSkillPrepare;
	public float skillPrepareTimeout;
	public int skillPrepareSpeedLevel;
	public ConfigAISkillCastCondition castCondition;
	public float cd;
	public float cdUpperRange;
	public float initialCD;
	public float initialCDUpperRange;
	public string publicCDGroup;
	public bool ignoreGCD;
	public bool triggerGCD;
	public bool triggerCDOnStart;
	public bool triggerCDOnFail;
	public int skillGroupCDID;
	public string[] stateIDs;
	public float skillQueryingTime;
	public int commandID;
	public string flagTargetReachable;
	public string flagSelfOnTemplateCollider;
	public string flagSelfInZone;
	public string flagTargetInZone;
	public ConfigAIBuddySkillCondition buddySkillCondition;
	public NeuronName[] nerveTrigger;
	public ConfigAINerveSkill nerveTarget;

	public class ConfigAINerveSkill
	{
		public bool enable;
		public ConfigAINerveTargetType nerveTargetType;
		public bool changeThreatTarget;
	}
	public class ConfigAIBuddySkillCondition
	{
		public float selectRange;
		public ConfigAIBuddyScoring buddyScoring;

		public class ConfigAIBuddyScoring
		{
			public int hpFactor;
			public float hpWeight;
			public float distFactor;
			public int distWeight;
			public float[] roleScores;
		}
	}
	public class ConfigAISkillCastCondition
	{
		public int[] pose;
		public bool needReInitCD;
		public float minTargetAngleXZ;
		public float maxTargetAngleXZ;
		public float maxTargetAngleY;
		public float minTargetAngleY;
		public float pickRangeMin;
		public float pickRangeMax;
		public float pickRangeYMax;
		public float pickRangeYMin;
		public ConfigAIRaycastCondition[] pickRangeByRaycast;
		public float SkillAnchorRangeMin;
		public float SkillAnchorRangeMax;
		public float TargetSkillAnchorRangeMin;
		public float TargetSkillAnchorRangeMax;
		public CondfigAIRangeType castRangeType;
		public float castRangeMin;
		public float castRangeMax;
		public ConfigAICastRangeXZ_Y castRangeXZ_Y;
		public string[] globalValues;
		public bool globalValuesLogicAnd;

		public class ConfigAICastRangeXZ_Y
		{
			public float castRangeXZMin;
			public float castRangeXZMax;
			public float castRangeYMin;
			public float castRangeYMax;
		}
	}
}