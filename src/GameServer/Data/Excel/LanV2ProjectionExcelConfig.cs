using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LanV2ProjectionExcelConfig
{
	public uint scheduleId;
	public float sensitivityFreeRotation;
	public float sensitivitySingleAxisRotation;
	public float sensitivitySingleAxisTranslation;
	public float sensitivityFreeRotationJoypad;
	public float sensitivitySingleAxisRotationJoypad;
	public float sensitivitySingleAxisTranslationJoypad;
	public uint pushTipsIdJoypad;
	public uint pushTipsIdTouch;
	public uint pushTipsIdMouse;
	public uint timeThresholdUnlockAnswer;
	public uint timeThresholdShowStandbyPrompt;
	public uint timeThresholdShowContinuousProgress;
	public string[] leadGuides;
	public string[] guides;
	public uint guideQuestId;
	public uint nameTextMapHash;
	public uint descTextMapHash;
}