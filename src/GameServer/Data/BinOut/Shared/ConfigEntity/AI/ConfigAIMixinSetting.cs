using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIMixinSetting
{
	public ConfigAIMixinSetControllerCondition[] setControllerParameterOnBeHitByEntityType;

	public class ConfigAIMixinSetControllerCondition
	{
		public int[] poseIDs;
		public ConfigAIMixinSetControllerParameter[] settings;

		public class ConfigAIMixinSetControllerParameter
		{
			public EntityType[] entityTypes;
			public ConfigAIMixinActions onSuccess;
			public ConfigAIMixinActions onFail;
		}
	}
}