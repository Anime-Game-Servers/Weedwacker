using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigCustomGadgetNode
{
	public CustomGadgetType customGadgetType;
	public CustomGadgetCameraSettings cameraSettings;
	public Dictionary<string, CustomGadgetNodeSlot> slotMap;

	public class CustomGadgetCameraSettings
	{
		public float gadgetHeight;
		public float minCameraRadius;
		public float minElevation;
		public float leftrightShift;
		public float upDownShift;
	}
	public class CustomGadgetNodeSlot
	{
		public string namedTransform;
		public CustomGadgetNodeSlotType slotType;
		public uint slotConfigId;
	}
}