using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class MultiBadmintonShootMixin : ConfigAbilityMixin
{
	public float minInterval;
	public float maxInterval;
	public float extraShootInterval;
	public string[] extraShootTag;
	public MultiBadmintonBullet[] bullets;
	public int tresBulletID;
	public int normalBulletID;
	public int traceBulletID;
	public string[] traceTarget;
	public int perChangeWeight;
	public ConfigBornType born;

	public class MultiBadmintonBullet
	{
		public uint bulletID;
		public int weight;
		public int speed;
	}
}
