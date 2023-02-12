using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioMusic
{
	public ConfigWwiseString stateGroupName;
	public ConfigWwiseString casualStateValue;
	public ConfigWwiseString combatPrepStateValue;
	public ConfigWwiseString combatStateValue;
	public ConfigWwiseString peaceStateValue;
	public ConfigWwiseString cityApproachTrigger;
	public ConfigWwiseString combatTrigger;
	public ConfigWwiseString combatMusicRtpc;
	public float outerEnemyConcernRange;
	public float innerEnemyConcernRange;
	public float attackFromBehindEnterDistance;
	public float attackFromBehindExitDistance;
	public float intentionInFrontProductThreshold;
	public float IntentionFromBehindProductThreshold;
	public float combatRtpcLowerBound;
	public float combatRtpcUpperBound;
	public int waitFramesTillStageMature;
	public ConfigWwiseString enemyMainStateGroup;
	public ConfigWwiseString defaultEnemyMainStateValue;
	public MusicEnemySettings[] enemySettings;
	public AudioStateOp skiffStateOp;

	public class MusicEnemySettings
	{
		public uint entityId;
		public ConfigWwiseString mainStateValue;
		public ConfigWwiseString auxStateGroup;
		public ConfigWwiseString defaultAuxStateValue;
		public MusicEnemyCombatPhaseState[] combatPhaseStates;

		public class MusicEnemyCombatPhaseState
		{
			public ConfigAICombatPhase combatPhase;
			public ConfigWwiseString stateValue;
		}
	}
}