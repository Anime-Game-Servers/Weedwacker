using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigPickup
{
	public PickType pickType;
	public bool isStatic;
	public float dropPointMaxYaw;
	public float dropPointMinSpeed;
	public float dropPointMaxSpeed;
	public string bornEffect;
	public string dropEffect;
	public Vector dropOffset;
	public bool enableScan;
	public bool lockYmove;
	public float suspendHeight;
	public float suspendSpeed;
	public float suspendAmplitude;
	public float rotateSpeed;
	public Vector rotateVec;
	public float attractDelayTime;
	public ConfigPickupMulti multi;
	public Vector dirVec;
	public float gravityRation;
	public bool disableInitJump;
	public float initBackSpeed;
	public float backDecelerate;
	public float backFanAngle;
	public float backFanStartAngle;
	public int reboundTimes;
	public float reboundRation;
	public float attractAccelerate;
	public float attractMaxDistance;
	public float heightOffset;
	public Vector rotateDecelerate;
	public string attractAudio;
	public bool isDummyPick;
	public bool isPickDestroy;

	public class ConfigPickupMulti
	{
		public Vector dirMinVec;
		public Vector dirMaxVec;
		public uint maxNum;
		public uint minNum;
		public float attractSpeed;
		public bool useWorldTrans;
		public bool isAutoAttract;
	}
}