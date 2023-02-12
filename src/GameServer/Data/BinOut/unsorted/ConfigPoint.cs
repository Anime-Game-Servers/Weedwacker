using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPoint
{
	public uint pointId;
	public Vector position;
	public Vector rotation;
	public float velocity;
	public float time;
	public bool isReachEvent;
	public Vector rotAxis;
	public float rotSpeed;
	public float arriveRange;
}