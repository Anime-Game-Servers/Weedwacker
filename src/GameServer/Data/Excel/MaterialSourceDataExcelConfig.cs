using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MaterialSourceDataExcelConfig
{
	public uint id;
	public uint[] dungeonList;
	public SourceJumpConfig[] jumpList;
	public uint[] dungeonGroup;
	public string[] jumpTargets;
	public uint[] jumpParams;
	public uint[] jumpDescs;
	public uint[] textList;

	public class SourceJumpConfig
	{
		public SourceJumpType jumpType;
		public uint jumpParam;
	}
}