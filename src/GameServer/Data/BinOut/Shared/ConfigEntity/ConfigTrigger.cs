using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigTrigger
{
	public EntityTriggerType triggerType;
	public TriggerFlag triggerFlag;
	public ConcernType concernType;
	public string shape;
	public Vector offset;
	public Vector eularOffset;
	public float height;
	public string fromShape;
	public Vector fromOffset;
	public Vector fromEularOffset;
	public float fromHeight;
	public bool checkInfinite;
	public bool triggerInfinite;
	public bool lifeInfinite;
	public float startCheckTime;
	public float checkInterval;
	public int checkCount;
	public float triggerInterval;
	public int triggerCount;
	public float lifeTime;
	public bool overwriteCampType;
	public TargetType campType;
	public bool checkPoint;
	public bool useSurfaceHeight;
	public bool useCollider;
	public string colliderName;
	public string fromColliderName;
	public bool checkGhost;
	public bool colliderCheckOnInit;
	public bool checkOnReconnect;
	public string[] colliderWhiteList;
	public string[] colliderBlackList;
	public bool useLevelOverride;
	public ConfigBaseShape rawShape;
	public bool useLocalTriggerLogic;
	public ConfigLocalTriggerMeta localTriggerMeta;
}
