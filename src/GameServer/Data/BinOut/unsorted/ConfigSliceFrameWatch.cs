using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSliceFrameWatch
{
	public float amortizedTickMassiveEntityBudget;
	public float sharedSliceFrameGameSystemTime;
	public float resourcesManagerAssetJobMinTime;
	public float resourcesManagerAssetJobMaxTime;
	public float resourcesManagerInstantiateMinTime;
	public float resourcesManagerInstantiateMaxTime;
	public float resourcesManagerUnloadMinTime;
	public float resourcesManagerUnloadMaxTime;
	public float resourcesManagerInstantiateJobTime;
	public float levelAppearDisappearTimeMSDefault;
	public int levelAppearDisappearWRRWeight;
	public float InitComponentCommonSlicingTimeDefault;
	public float removeEntityTimeMSDefault;
	public int removeEnityWRRWeight;
	public int sectrWRRWeightDefault;
	public float timerManagerTimeMS;
	public bool UseLegacyGenericObjectPool;
	public int significanceTaskThreadLOD;
	public bool loadingUseSyncLoad;
}