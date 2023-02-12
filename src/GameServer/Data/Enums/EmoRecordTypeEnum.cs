
namespace Weedwacker.GameServer.Data.Enums;

public enum EmoRecordTypeEnum : int
{
	ResetEmotion = 0,
	ResetPhoneme = 1,
	SetEmotion = 2,
	SetPhoneme = 3,
	SetEmotionAndPhoneme = 4,
	Toggle = 5,
	PlaySequenceSub = 6,
	PlaySequence = 7,
	ClearEmotion = 8,
	ToggleEyeCtrl = 9,
	ClearSequence = 10,
	Blink = 11,
}