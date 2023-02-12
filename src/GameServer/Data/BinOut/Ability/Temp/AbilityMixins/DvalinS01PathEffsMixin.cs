using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DvalinS01PathEffsMixin : ConfigAbilityMixin
{
	public int effectStart;
	public int effectEnd;
	public DvalinS01PathEffsInfo[] effInfos;
}

public class DvalinS01PathEffsInfo
{
	public int flyState;
	public string effectName;
	public bool pathCenter;
	public int intervalMax;
	public int intervalMin;
	public int numMax;
	public int numMin;
	public float rangeMax;
	public float rangeMin;
	public float eularMax;
	public float eularMin;
	public float yScale;
}
