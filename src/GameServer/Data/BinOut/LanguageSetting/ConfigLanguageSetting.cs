using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLanguageSetting
{
	public Dictionary<string, TextLanguageType[]> textShowTypes;
	public Dictionary<string, TextLanguageType[]> textDisableTypes;
	public Dictionary<string, VoiceLanguageType[]> voiceShowTypes;
	public Dictionary<string, VoiceLanguageType[]> voiceDisableTypes;
}