using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIThreatSetting
{
	public bool enable;
	public float clearThreatTargetDistance;
	public float clearThreatEdgeDistance;
	public bool clearThreatByLostPath;
	public bool clearThreatByTargetOutOfZone;
	public float clearThreatTimerByDistance;
	public float clearThreatTimerByLostPath;
	public float clearThreatTimerByTargetOutOfZone;
	public float viewThreatGrow;
	public float hearThreatGrow;
	public float feelThreatGrow;
	public float threatDecreaseSpeed;
	public float threatBroadcastRange;
	public AIPoint[] viewAttenuation;
	public AIPoint[] hearAttenuation;
	public float timeDecreaseTemper;
	public TauntLevel resistTauntLevel;
	public float auxScoreChangeTargetCD;
	public ConfigAITSAbilityGlobalValueSetting abilityGlobalValueScoreSystem;
	public ConfigAITSTargetDistanceSetting targetDistanceScoreSystem;
	public ConfigAITSTargetBearingSetting targetBearingScoreSystem;

	public class AIPoint
	{
		public float x;
		public float y;
	}
	public class ConfigAIThreatScoreBaseSetting
	{
		public bool enable;
		public int weight;
		public float value;
		public float min;
		public float max;
		public OrderingType compareOperation;
	}
	public class ConfigAITSAbilityGlobalValueSetting : ConfigAIThreatScoreBaseSetting
	{
		public string caredGlobalValueName;
	}
	public class ConfigAITSTargetDistanceSetting : ConfigAIThreatScoreBaseSetting
	{
	}
	public class ConfigAITSTargetBearingSetting : ConfigAIThreatScoreBaseSetting
	{
	}
}