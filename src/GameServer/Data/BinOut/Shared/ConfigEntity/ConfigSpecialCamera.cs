using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigSpecialCamera
{
	public float priority;
	public float enterRadius;
	public float exitRadius;
	public float heightAdjust;
	public float fov;
	public float zoom;
	public float sphericalY;
	public bool lockSphericalY;
	public float sphericalYUp;
	public float sphericalYDown;
	public float autoTurnStartMin;
	public float autoTurnStartMax;
	public float autoTurnEndMin;
	public float autoTurnEndMax;
	public string enterShape;
	public string exitShape;
	public Vector shapeCenterOffset;
}