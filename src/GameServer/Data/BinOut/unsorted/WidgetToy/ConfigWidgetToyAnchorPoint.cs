using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyAnchorPoint : ConfigBaseWidgetToy
{
	public uint coolDown;
	public uint lastingTime;
	public uint maxCountInScene;
	public uint gadgetId;
	public uint[] invalidSceneIds;
}