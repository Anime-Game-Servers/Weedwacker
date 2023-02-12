using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetAnchorPoint : ConfigBaseWidget
{
	public uint lastingTime;
	public uint maxCountInScene;
	public uint gadgetId;
	public uint[] invalidSceneIds;
}