using Weedwacker.GameServer.Data.BinOut.UI;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigUIGlobal
{
	public Dictionary<InputActionType, ConfigBaseInputAction> inputActions;
	public Dictionary<InputEventType, ConfigBaseInputEvent> inputEvents;
	public Dictionary<string, InputActionEvent[]> actionGroups;
	public Dictionary<string, ConfigBaseContext> inputModes;
	public Point2D joypadChangeViewScale;
	public float joypadLongPressDuration;
	public float[] joypadSenseScales;
	public float[] joypadFocusSenseScales;
	public float[] mouseSenseScales;
	public float[] mouseFocusSenseScales;
	public float[] touchpadSenseScales;
	public float[] touchpadFocusSenseScales;
	public float[] touchpadFocusAccelerationScales;
	public TouchpadFocusAccelerationSigmoidPara touchpadFocusAccelerationPara;
	public ConfigUIPhotograph configUIPhotograph;
	public ConfigInputCheck configInputCheck;

	public class TouchpadFocusAccelerationSigmoidPara
	{
		public float phase;
		public float slope;
		public float amplitude;
		public float clip;
	}
	public class ConfigInputCheck
	{
		public ConfigInputEventCheckWhiteList configInputEventCheckWhiteList;

		public class ConfigInputEventCheckWhiteList
		{
			public InputEventType[] globalWhiteList;
			public Dictionary<InputEventType, string[]> configContextInputEventWhiteListMap;
		}
	}
	public class ConfigUIPhotograph
	{
		public float fovMax;
		public float fovMin;
		public float cameraShiftUp;
		public float cameraShiftDown;
		public float cameraShiftLeft;
		public float cameraShiftRight;
		public float blurDistance;
		public float blurRange;
		public float blurAmount;
	}
}