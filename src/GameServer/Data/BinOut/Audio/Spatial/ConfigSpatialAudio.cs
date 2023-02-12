using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSpatialAudio
{
	public uint sceneId;
	public ConfigSpatialRoom[] roomList;
	public ConfigSpatialPortal[] portalList;
	public string globalRoom;

	public class ConfigSpatialRoom
	{
		public string name;
		public ConfigWwiseString reverbAuxBus;
		public float reverbLevel;
		public float wallOcclusion;
		public float auxSendLevelToSelf;
		public bool keepRegister;
		public int priority;
		public bool isMajorRoom;
		public ConfigSpatialBoxRoomTrigger[] boxRoomTriggers;
		public ConfigSpatialSphereRoomTrigger[] sphereRoomTriggers;

		public class ConfigSpatialBoxRoomTrigger
		{
			public Vector position;
			public Vector rotation;
			public Vector size;
		}
		public class ConfigSpatialSphereRoomTrigger
		{
			public Vector position;
			public float radius;
		}
	}
	public class ConfigSpatialPortal
	{
		public string name;
		public Vector position;
		public Vector rotation;
		public Vector size;
		public bool enabled;
		public string frontRoomName;
		public string backRoomName;
	}
}