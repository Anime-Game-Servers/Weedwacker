using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigQTEStepButtonComponent : ConfigQTEStepBaseComponent
{
	public uint positionId;
	public QTEStepButtonInputType inputEvent;
	public ConfigQTEStepCondActionGroup[] clickTrigger;
	public QTEStepButtonStyleType style;
	public float countDownTime;
	public ConfigQTEStepCondActionGroup[] countDownChangeTrigger;
	public ConfigQTEStepCondActionGroup[] slideDirTrigger;
	public QTEStepButtonSlideDirectType slideDir;
	public float slideAngle;
	public float slideTouchDis;
	public float slideJoypadDis;
}