using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetMaterialParamFloatByTransform : ConfigAbilityAction
{
	public string matName;
	public string patternName;
	public object value;
	public bool useCurve;
	public uint lerpCurveIndex;
	public float lerpTime;
}
