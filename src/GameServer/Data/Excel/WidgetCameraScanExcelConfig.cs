using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WidgetCameraScanExcelConfig
{
	public uint id;
	public uint cameraID;
	public uint configID;
	public uint[] scannableState;
	public bool isHint;
	public WidgetCameraActionType action;
}