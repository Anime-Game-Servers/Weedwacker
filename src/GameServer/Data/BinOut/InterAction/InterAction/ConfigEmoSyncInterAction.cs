using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigEmoSyncInterAction : ConfigBaseInterAction
{
	public string dataPath;
	public string phonemePath;
	public string emotionPath;
	public string mateDataPath;
	public string matePhonemePath;
	public string mateEmotionPath;
	public EmoBackType backType;
	public bool enableBlink;
	public ulong[] dataPathHashList;
	public ulong[] phonemePathHashList;
	public ulong[] emotionPathHashList;
	public ulong[] mateDataPathHashList;
	public ulong[] matePhonemePathHashList;
	public ulong[] mateEmotionPathHashList;
}