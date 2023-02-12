using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyMiracleRing : ConfigBaseWidgetToy
{
	public bool isAllowedInDungeon;
	public bool isAllowedInRoom;
	public uint maxCountInScene;
	public uint maxCountByPlayer;
	public uint createGadgetId;
	public float distanceToAvatar;
	public float radius;
	public float combatDestroyDistance;
}