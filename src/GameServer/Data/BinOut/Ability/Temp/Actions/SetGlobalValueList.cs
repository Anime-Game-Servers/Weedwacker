
namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetGlobalValueList : ConfigAbilityAction
{
	public GlobalValuePair[] globalValueList;

	public class GlobalValuePair
	{
		public string key;
		public object value;
		public bool useLimitRange;
		public bool randomInRange;
		public object maxValue;
		public object minValue;
	}
}