using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigUIIndicator
{
	public TemplateParamString icon;
	public IndicatorDistanceInfoType distance_Show;
	public bool followMove;
	public IndicatorLogic[] indicator;

	public class IndicatorLogic
	{
		public IndicatorOperator iOperator;
		public IndicatorCondition[] iConditions;
	}
}