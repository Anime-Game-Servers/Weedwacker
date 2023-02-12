using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetGadget
{
	public uint maxCountInScene;
	public uint maxCountByPlayer;
	public bool isCombatDestroy;
	public float combatDestroyDistance;
	public bool isDistanceDestroy;
	public float distanceDestroyDistance;
	public bool isHasCollision;
	public bool collisionIncludeNpc;
	public bool collisionIncludeWater;
	public float radius;
	public float distanceToAvatar;
	public float createHeight;
	public Vector createRot;
	public bool isLeaveSceneDestroy;
}