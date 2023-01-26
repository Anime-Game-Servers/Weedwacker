using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LogicType
	{
		None,
		Equal,
		Greater,
		GreaterOrEqual,
		Lesser,
		LesserOrEqual,
		LOGIC_OR,
		LOGIC_AND,
		LOGIC_A_AND_ETCOR,
		LOGIC_A_AND_B_OR_ETCAND,
		LOGIC_A_AND_B_AND_ETCOR,
		LOGIC_A_OR_ETCAND
	}
}
