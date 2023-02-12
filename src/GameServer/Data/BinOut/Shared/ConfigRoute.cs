using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigRoute
{
	public uint localId;
	public string name;
	public RouteType type;
	public bool isForward;
	public ConfigWaypoint[] points;
	public RotType rotType;
	public RotAngleType rotAngleType;
	public float arriveRange;

	public class ConfigWaypoint
	{
		public Vector pos;
		public float waitTime;
		public float moveAngularSpeed;
		public float waitAngularSpeed;
		public float moveRotateRound;
		public float waitRotateRound;
		public bool stopWaitRotate;
		public int speedLevel;
		public float targetVelocity;
		public bool hasReachEvent;
		public float rotAngleMoveSpeed;
		public float rotAngleWaitSpeed;
		public bool rotAngleSameStop;
		public Vector rotRoundReachDir;
		public int rotRoundReachRounds;
		public Vector rotRoundLeaveDir;
		public int rotRoundWaitRounds;
		public bool reachStop;
	}
}
