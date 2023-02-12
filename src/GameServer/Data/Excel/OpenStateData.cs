using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("OpenStateConfigData.json")]
public class OpenStateData
{
	public uint id; // maps to OpenStateType enum
	public bool defaultState;
	public bool allowClientOpen;
	public OpenStateCond[] cond;
	public uint system_open_ui_id;

	public class OpenStateCond
	{
		public OpenStateCondType cond_type;
		public uint param;
		public uint param2;
	}
}
