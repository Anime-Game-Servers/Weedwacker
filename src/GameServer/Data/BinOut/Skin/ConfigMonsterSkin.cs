using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMonsterSkin : ConfigSkin
{
	public SkinColor[] skinColors;

	public class SkinColor
	{
		public string renderer;
		public int index;
		public int channel;
		public string color;
	}
}