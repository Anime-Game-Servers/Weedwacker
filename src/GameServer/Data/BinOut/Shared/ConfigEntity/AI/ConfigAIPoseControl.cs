
namespace Weedwacker.GameServer.Data;

public class ConfigAIPoseControl
{
	public ConfigAIPoseControlItem[] items;

	public class ConfigAIPoseControlItem
	{
		public float minTime;
		public float maxTime;
		public int poseID;
		public int[] RandomPose;
		public bool switchOnlyInCanDoSkillState;
	}
}