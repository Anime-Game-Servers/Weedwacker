using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGlobalSwitch
{
	public bool enableMultiPlayer;
	public bool enableAnimatorInterleave;
	public bool enableMixinModifierDetachCallback;
	public bool enablePacketProcessTimeLimit;
	public bool enableUITempFix;
	public bool enableEquipDataItemFix;
	public bool cacheEntityLightDeActive;
	public bool enablemaxDelayPacketMs;
	public uint maxDelayPacketMs;
	public bool enableForceSyncPostion;
	public float maxForceDistance;
	public bool enableAbilityInvokeAfterReady;
}