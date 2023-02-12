using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigNormalStateIDInfo : ConfigBaseStateIDInfo
{
	public Dictionary<string, string[]> animatorStates;
	public MoveType moveType;
	public bool combatMoveOnWater;
	public bool canDoSkill;
	public float canDoSkillStart;
	public float canDoSkillEnd;
	public bool canSyncMove;
	public bool cullingModelAlwaysAnimate;
	public float addEndure;
	public float massRatio;
	public string[] resetAnimatorTriggerOnEnter;
	public string[] resetAnimatorTriggerOnExit;
	public ConfigAnimatorBoolean[] setAnimatorBoolean;
	public ConfigAnimatorFloat[] setAnimatorFloat;
	public bool enableRagDoll;
	public bool needFaceToAnimParam;
	public bool enableCCD;
	public bool handleAnimatorStateImmediately;

	public class ConfigAnimatorBoolean
	{
		public string name;
		public float normalizeStart;
		public float normalizeEnd;
	}
	public class ConfigAnimatorFloat
	{
		public string name;
		public float normalizeStart;
		public float normalizeEnd;
		public float value;
	}
}