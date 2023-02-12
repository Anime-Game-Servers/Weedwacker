using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

namespace Weedwacker.GameServer.Data;

public class ConfigNpc : ConfigCharacter
{
	public float defaultDither;
	public float disappearDuration;
	public ConfigAIBeta aibeta;
	public ConfigMove move;
	public ConfigIntee intee;
	public ConfigGadgetAudio audio;
	public ConfigEmojiBubble emojiBubble;
}