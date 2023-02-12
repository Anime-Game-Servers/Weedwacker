using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("AvatarCurveExcelConfigData.json")]
public class AvatarCurveData
{
	public uint level;
	public GrowCurveInfo[] curveInfos;

	public Tuple<ArithType, float> GetArith(GrowCurveType type)
	{
		foreach (GrowCurveInfo curveInfo in curveInfos)
		{
			if (curveInfo.type == type) return Tuple.Create(curveInfo.arith, curveInfo.value);
		}
		Logger.WriteErrorLine("Could not find value for " + type + " for avatar level:" + level);
		return Tuple.Create(ArithType.ARITH_MULTI, (float)1.0);
	}
}