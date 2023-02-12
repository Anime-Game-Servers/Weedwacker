using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DiePatternSwitchMixin : ConfigAbilityMixin
{
	public DiePatternSwitchMixinPriority priority;
	public bool hasAnimatorDie;
	public bool muteAllShaderDieEff;
	public bool fallWhenAirDie;
	public float dieEndTime;
	public float dieForceDisappearTime;
	public string dieDisappearEffect;
	public float dieDisappearEffectDelay;
	public E_ShaderData dieShaderData;
	public float dieShaderEnableDurationTime;
	public float dieShaderDisableDurationTime;
	public float dieModelFadeDelay;
	public float ragDollDieEndTimeDelay;
	public bool startDieEndAtOnce;
	public bool notSendDieTrigger;
	public bool ignoreElementDie;
	public bool muteHitBox;
	public bool dieDenyLockOn;
	public bool dieIsGhostToEnemy;
	public bool dieIgnoreTriggerBullet;
	public bool muteBillboard;
	public bool mutePushCollider;
}
