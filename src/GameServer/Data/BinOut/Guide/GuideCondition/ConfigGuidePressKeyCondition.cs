using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuidePressKeyCondition : ConfigGuideCondition
{
	public InputEventType eventID;
	public InputEventType endEventID;
	public GuideKeyClick type;
	public float value;
}