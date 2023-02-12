using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigCombatLock
{
	public string lockShape;
	public bool denyLockOn;
	public float lockWeightYaxisParam;
	public float lockWeightYaxisThreshold;
	public string lockType;
	public float overrideRange;
	public float overrideNormalPri;
	public float overrideCombatPri;
}
