using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelMonsterData
{
	public uint sceneId;
	public ConfigLevelMonsterUnit[] monsters;

	public class ConfigLevelMonsterUnit
	{
		public uint groupId;
		public uint mapInstId;
		public bool spawnedByEvtPattern;
		public int routeId;
		public ConfigLevelMonsterAIPatrol aiPatrolSetting;
		public uint aiGroupID;
		public bool overrideDefendAreaRange;
		public float defendAreaRange;
		public bool overrideForceAlertDistance;
		public float forceAlertDistanceLimit;
		public uint defendAreaID;
		public uint wanderAreaID;
		public bool overrideClearThreatTargetDistance;
		public float clearThreatTargetDistance;
		public string aiNeuronSetting;
		public string aiSensingTemplate;
		public bool forceCombatOnSpawn;
		public bool disableWander;
		public bool standOnDistantMesh;
		public uint landingPointID;
		public uint extractionPointID;
		public bool overrideUseNavmesh;
		public bool useNavmesh;
		public bool billboard_HasUIBar;
		public float billboard_ShowUIBarDis;
		public float billboard_HideUIBarDis;
		public bool billboard_UIBarNeedEnterCombat;
		public HpBarStyle billboard_HpBarStyle;
		public uint billboard_MultiBarSortId;
		public uint billboard_MultiBarNum;
		public string reuseNotRemoveAbilityTag;

		public class ConfigLevelMonsterAIPatrol
		{
			public uint aiPatrolGroupId;
			public bool aiPatrolIsLeader;
			public Point2D aiPatrolOffset;
		}
	}
}