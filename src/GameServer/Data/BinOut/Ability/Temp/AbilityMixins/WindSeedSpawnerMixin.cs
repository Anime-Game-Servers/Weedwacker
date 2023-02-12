using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class WindSeedSpawnerMixin : ConfigAbilityMixin
{
	public bool refreshEnable;
	public float spawnerRadius;
	public float spawnerHeightAngle;
	public float spawnerAreaAngle;
	public float minDistanceToAvatar;
	public float moveSuppressSpeed;
	public float moveRefreshAngleFreeze;
	public float moveRefreshAngleSlow;
	public uint minNumPerSpawn;
	public uint maxNumPerSpawn;
	public uint maxSwapNumPerSpawn;
	public float minSeparateRange;
	public float maxSeparateRange;
	public float removeSeedDistance;
	public float refreshMeterPerMeter;
	public float refreshMeterPerSecond;
	public float refreshMeterPerDistRemove;
	public float refreshMeterMax;
	public string windForceModifier;
	public string windExplodeModifier;
	public string windBulletAbility;
	public string globalValueKey;
	public uint[] spawnNumArray;
	public uint seedGadgetID;
	public float initSignalStrength;
	public float triggerSignalStrength;
	public float signalDecaySpeed;
	public float mutipleRange;
	public float catchSeedRange;
}