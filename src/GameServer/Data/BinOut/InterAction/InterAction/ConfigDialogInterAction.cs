using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigDialogInterAction : ConfigBaseInterAction
{
	public DialogType dialogType;
	public uint dialogID;
	public float protectTime;
	public bool playAudio;
	public bool autoTalkUseNewProtectTime;
	public float autoTalkProtectTime;
}