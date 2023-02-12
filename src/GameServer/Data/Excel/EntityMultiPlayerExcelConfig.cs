using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class EntityMultiPlayerExcelConfig
{
	public uint id;
	public EntityPropPerMpConfig[] propPerVec;
	public uint[] endureNumVec;
	public float[] elementShieldPerVec;

	public class EntityPropPerMpConfig
	{
		public FightPropType propType;
		public float[] propValueVec;
	}
}