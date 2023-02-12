using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class CircleBarrageMixin : ConfigAbilityMixin
{
	public uint bulletID;
	public float innerRadius;
	public int cutNum;
	public int waveNum;
	public float waveCD;
	public int wavebulletNum;
	public float waveangle;
	public float triggerCD;
	public string shootPoint;
}
