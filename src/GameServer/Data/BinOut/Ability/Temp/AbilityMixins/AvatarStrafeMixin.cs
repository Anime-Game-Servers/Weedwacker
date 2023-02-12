using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AvatarStrafeMixin : ConfigAbilityMixin
{
	public StrafeConfig[] configList;

	public class StrafeConfig
	{
		public string[] stateIds;
		public float? strafeMoveSpeed;
		public bool? rotateToTarget;
		public bool? useGravity;
		public bool? useRootMotion;
		public float? angularSpeed;
	}
}
