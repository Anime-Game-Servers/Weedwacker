using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType;

public class SelectTargetsByShape : SelectTargets
{
	public string shapeName;
	public AbilityTargetting centerBasedOn;
	public TargetType campTargetType;
	public AbilityTargetting campBasedOn;
	public object sizeRatio;
}
