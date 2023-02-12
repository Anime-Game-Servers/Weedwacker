using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMusicGame
{
	public ConfigMusicGameKey[] button_sequence;
	public int instrument;
	public ConfigWwiseString playMusicEvent;
	public ConfigWwiseString stopMusicEvent;
	public ConfigWwiseString pauseMusicEvent;
	public ConfigWwiseString resumeMusicEvent;
	public bool autoPlay;

	public class ConfigMusicGameKey
	{
		public MusicKeyType button;
		public uint time;
		public int note;
		public bool isLongPress;
		public uint longPressTime;
	}
}