
namespace Weedwacker.GameServer.Data;

public class ConfigAnimationCurve
{
	public ConfigKeyframe[] keyframes;

	public class ConfigKeyframe
	{
		public float time;
		public float value;
		public float inTangent;
		public float outTangent;
	}
}