using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigGadgetConsole
{
	public string inTriggerAbilityName;
	public string outTriggerAbilityName;
	public string reminderTextMap;
	public float reminderVanishDelay;
	public string cameraAttachPoint;
	public uint finishGadgetState;
	public ConfigGadgetConsoleOperation[] operations;
	public ConfigGadgetConsoleLimitation[] limitations;
	public ConfigGadgetConsolePosition[] finishPosition;

	public class ConfigGadgetConsoleOperation
	{
		public string operationName;
		public string transName;
		public ConfigGadgetConsoleOperationType moveType;
		public float moveSpeed;
		public bool hasDisableValue;
		public float disableValue;
	}
	public class ConfigGadgetConsoleLimitation
	{
		public string transName;
		public ConfigGadgetConsoleOperationType moveType;
		public bool hasMin;
		public float min;
		public bool hasMax;
		public float max;
	}
	public class ConfigGadgetConsolePosition
	{
		public string transName;
		public Vector rotation;
	}
}