using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIBeta
{
	public bool enable;
	public int friendliness;
	public DecisionArchetype decisionArchetype;
	public ConfigAIMove moveSetting;
	public ConfigAIPrecombatSetting precombat;
	public ConfigAICombatSetting aiCombat;
	public ConfigAIBuddySetting buddySetting;
	public ConfigAISensing sensing;
	public Dictionary<string, NeuronName[]> neurons;
	public ConfigAINeuronExtSettings neuronSetting;
	public ConfigAIThreatSetting threat;
	public ConfigAIOrderSetting order;
	public ConfigAIDefendArea defendArea;
	public ConfigAIFlySetting fly;
	public ConfigAIPoseControl poseControl;
	public ConfigAIUISetting ui;
	public ConfigAIProfilingSetting profiling;
	public ConfigAINetworkSetting network;
	public ConfigAISkillGroupCD[] skillGroupCDConfigs;
	public ConfigAISkillSetting skillSetting;
	public Dictionary<string, ConfigAISkill> skills;
	public float skillGCD;
	public ConfigAITarget target;
	public ConfigAIReturnToBornPosSetting returnToBornTactic;
	public ConfigAIWanderSetting wanderTactic;
	public ConfigAIFollowScriptedPathSetting followScriptedPathTactic;
	public ConfigAIFollowServerRouteSetting followServerRouteTactic;
	public ConfigAIInvestigateSetting investigateTactic;
	public ConfigAIReactActionPointSetting reactActionPointTactic;
	public ConfigAIPatrolFollowSetting patrolFollowTactic;
	public ConfigAICombatFollowMoveSetting combatFollowMoveTactic;
	public ConfigAIMeleeChargeSetting meleeChargeTactic;
	public ConfigAIFacingMoveSetting facingMoveTactic;
	public ConfigAISurroundSetting surroundTactic;
	public ConfigAIGroupSurroundSetting groupSurroundTactic;
	public ConfigAIFindBackSetting findBackTactic;
	public ConfigAICombatFixedMoveSetting combatFixedMoveTactic;
	public ConfigAICrabMoveSetting crabMoveTactic;
	public ConfigAIFleeSetting fleeTactic;
	public ConfigAIFleeOnBlockAvatarLandingSetting fleeOnBlockAvatarLandingTactic;
	public ConfigAISpacialChaseSetting spacialChaseTactic;
	public ConfigAISpacialProbeSetting spacialProbeTactic;
	public ConfigAISpacialAdjustSetting spacialAdjustTactic;
	public ConfigAISpacialWanderSetting spacialWanderTactic;
	public ConfigAIBirdCirclingSetting birdCirclingTactic;
	public ConfigAIScriptedMoveToSetting scriptedMoveToTactic;
	public ConfigAILandingSetting landingTactic;
	public ConfigAIExtractionSetting extractionTactic;
	public ConfigAIBrownianMotionSetting brownianMotionTactic;
	public ConfigAISpacialFacingMoveSetting spacialFacingMoveTactic;
	public ConfigAIMixinSetting mixin;
	public ConfigAIFishingBitesBaitSetting fishingBitesBaitTactic;
	public ConfigAIFishingPretendBitesSetting fishingPretendBitesTactic;
	public ConfigAIFishingFleeSetting fishingFleeTactic;
}