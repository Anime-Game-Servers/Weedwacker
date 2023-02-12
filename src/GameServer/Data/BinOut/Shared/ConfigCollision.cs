using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigCollision
{
	public ConfigCCD ccd;
	public ColliderTriggerType triggerType;
	public float triggerCD;
	public TargetType targetType;
	public bool ignoreScene;
	public bool ignoreWater;
	public bool bornWithTriggerEnabled;
	public float delayEnableCollision;

	public class ConfigCCD
	{
		public CCDType type;
		public float detectCd;
	}
	public class Always : ConfigCCD
	{
		//...
	}
}
