
namespace Weedwacker.GameServer.Data;

public class BoredCreateMonsterExcelConfig
{
	public uint player_level;
	public BoredMonsterConfig[] monster_config_vec;

	public class BoredMonsterConfig
	{
		public uint weight;
		public uint id;
	}
}