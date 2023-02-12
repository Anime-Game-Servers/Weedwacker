
namespace Weedwacker.GameServer.Data;

public class ConfigAISensing
{
	public bool enable;
	public Dictionary<string, ConfigAISensingSetting> settings;
	public Dictionary<string, Dictionary<string, string>> templates;

	public class ConfigAISensingSetting
	{
		public float sensitivity;
		public bool enableVision;
		public float viewRange;
		public bool viewPanoramic;
		public float horizontalFov;
		public float verticalFov;
		public bool useEyeTransformRotation;
		public float hearAttractionRange;
		public float hearFootstepRange;
		public float feelRange;
		public float sourcelessHitAttractionRange;
	}
}