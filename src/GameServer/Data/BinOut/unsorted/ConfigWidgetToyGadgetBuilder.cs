using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyGadgetBuilder : ConfigBaseWidgetToy
{
	public uint lastingTime;
	public uint maxCountInScene;
	public uint maxCountByPlayer;
	public uint gadgetId;
	public float distanceToAvatar;
	public float heightToAvatar;
	public float radius;
	public bool checkCollision;
}