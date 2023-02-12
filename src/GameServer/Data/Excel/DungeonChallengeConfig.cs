using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DungeonChallengeConfig
{
	public uint id;
	public uint targetTextTemplateTextMapHash;
	public uint subTargetTextTemplateTextMapHash;
	public uint progressTextTemplateTextMapHash;
	public uint subProgressTextTemplateTextMapHash;
	public string iconPath;
	public ChallengeType challenge_type;
	public bool isForwardTiming;
	public ChallengeRecordType recordType;
	public bool noSuccessHint;
	public bool noFailHint;
	public bool noPauseHint;
	public InterruptButtonType interruptButtonType;
	public bool isTransBackWhenInterrupt;
	public bool isSuccessWhenNotSettled;
	public bool isBlockTopTimer;
	public SubChallengeFadeOutType subChallengeFadeOutRule;
	public float subChallengeFadeOutDelayTime;
	public SubChallengeBannerType subChallengeBannerRule;
	public uint activitySkillID;
	public string[] teamAbilityGroupList;
}