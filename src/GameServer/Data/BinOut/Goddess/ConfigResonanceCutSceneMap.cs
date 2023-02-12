using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigResonanceCutSceneMap
{
	public Dictionary<ElementType, ConfigResonanceCutScene> cutsceneMap;

	public class ConfigResonanceCutScene
	{
		public uint cutsceneIndex;
		public string vfxAbility;
	}
}