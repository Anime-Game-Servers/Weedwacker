using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MusicGameDrumConfig
{
	public uint id;
	public float[] delaySettingRange;
	public float[] dropSpeedSettingRange;
	public float[] keySoundSettingRange;
	public float[] perfectRange;
	public float[] greatRange;
	public uint longPressEndCompensation;
	public uint failTime;
	public uint longPressHitInterval;
	public uint ugcPerMusicNum;
	public uint ugcMaxHistoryNum;
	public uint ugcMaxSavedScoreNum;
	public uint ugcMaxNoteNum;
	public float[] ugcRegionalNoteLimit;
	public float ugcLongPressNoteWeight;
	public float[] ugcRankScoreRatioList;
	public uint ugcPublishLimit;
	public float ugcPrefixPlayTime;
	public float ugcSuffixPlayTime;
	public uint ugcUndoBufferSize;
	public float[] ugcEditViewportRange;
	public float[] ugcTimeLineViewportRange;
	public float[] calibMusicInfo;
	public float[] calibViewportRange;
	public uint ugcAutoAttachBeatCount;
	public uint[] ugcTutorialPushTipIds;
	public uint[] comboEffectShowCount;
	public uint[] ugcEditorPushTipIds;
	public float[] ugcCursorMoveParams;
	public float[] ugcMusicPlaySpeedList;
	public uint[] ugcTutorialBlackList;
}