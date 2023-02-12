using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigEffectData
{
	public ConfigElementView elementView;
	public ConfigBeHitEffect beHit;
	public ConfigRecoverEnergyEffect[] recoverEnergy;
	public ConfigEffectPool effectPool;
	public Dictionary<string, string> scenePropShakeAnim;
	public ConfigEffectLOD effectLOD;
	public Dictionary<string, ConfigSkipUnindexedEffectCreation> skipUnindexedEffectCreation;
	public Dictionary<string, TokenForceEnqueueReason> tokenForceEnqueueMap;
	public string[] tokenForceHandleThisFrameArray;
	public string[] tokenIgnoreTickLod;
	public string[] logicEffect;

	public class ConfigSkipUnindexedEffectCreation
	{
		public ConfigSkipUnindexedEffectCreationByDistance skipUnindexedEffectCreationByDistance;

		public class ConfigSkipUnindexedEffectCreationByDistance
		{
			public float distance;
		}
	}
	public class ConfigRecoverEnergyEffect
	{
		public ElementType elementType;
		public ConfigEffectWithThreshold[] effects;

		public class ConfigEffectWithThreshold
		{
			public float threshold;
			public string effectName;
		}
	}
	public class ConfigElementView
	{
		public Dictionary<string, int> elementColorIndex;
		public uint terrainGrassColor;
	}
	public class ConfigBeHitEffect
	{
		public EntityBeHitEffect entity;
		public SceneBeHitEffect scene;

		public class EntityBeHitEffect
		{
			public string overrideByFrozenState;
			public string overrideByPetrifactionState;
			public string overrideByRockState;
			public string overrideByRockResistState;
		}
		public class SceneBeHitEffect
		{
			public Dictionary<string, Dictionary<string, string>> hitSceneEffect;
		}
	}
	public class ConfigEffectLOD
	{
		public EntityType[] useDistanceLODEntityTypes;
	}
}