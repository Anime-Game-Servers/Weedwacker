
namespace Weedwacker.GameServer.Data;

public class ConfigBaseEquipController
{
	public string sheathPoint;
	public float dissolveSheathFadeDelay;
	public float dissolveSheathFadeTime;
	public float dissolveTakeFadeTime;
	public TriggerToStates[] triggerToStates;

	public class TriggerToStates
	{
		public string trigger;
		public float playTime;
		public string[] states;
		public BowDrawTime[] bowDrawTimes;
		public string floatID;
		public float floatValue;

		public class BowDrawTime
		{
			public float bowDrawStartNormTime;
			public float bowDrawEndNormTime;
			public string bowStringOverridePoint;
		}
	}
}