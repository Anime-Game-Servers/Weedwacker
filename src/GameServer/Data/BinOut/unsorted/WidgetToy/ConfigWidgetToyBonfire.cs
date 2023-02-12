using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyBonfire : ConfigBaseWidgetToy
{
	public uint coolDown;
	public uint lastingTime;
	public uint maxCountInScene;
	public uint maxCountByPlayer;
	public uint gadgetId;
	public float distanceToAvatar;
	public float radius;
	public float combatDestroyDistance;
}