using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigBornType
{
	public DynamicFloatVector offset;
	public BornRandom bornRandom;
	public bool onGround;
	public bool onGroundIgnoreWater;
	public float onGroundRaycastUpDist;
	public ConfigBornDirectionType direction;
	public bool alongGround;
	public bool useRotation;
}
