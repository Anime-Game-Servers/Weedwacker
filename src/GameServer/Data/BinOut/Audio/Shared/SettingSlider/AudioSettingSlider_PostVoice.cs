
namespace Weedwacker.GameServer.Data;

public class AudioSettingSlider_PostVoice : AudioSettingSlider
{
	public AudioSettingSlider_PostVoiceItem[] changeVoiceArray;

	public class AudioSettingSlider_PostVoiceItem
	{
		public VoiceTriggerIdentity voiceTriggerIdentity;
		public uint repeatCount;
	}
}