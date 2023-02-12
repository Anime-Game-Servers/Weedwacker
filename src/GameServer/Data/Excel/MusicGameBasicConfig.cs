using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MusicGameBasicConfig
{
	public uint id;
	public uint musicID;
	public uint musicLevel;
	public string jsonPath;
	public uint longPressInterval;
	public float longPressDownSpeed;
	public uint longPressPreTime;
	public float successPrePoint;
	public float successLatePoint;
	public uint scaleTime;
	public uint lateDropTime;
	public float scaleRange;
	public uint[] scoreLevelList;
	public uint scoreOneKey;
	public uint scoreGreat;
	public uint scoreLongPress;
	public float bpm;
	public Dictionary<uint, float> bpmDict;
	public uint[] ugcBeatDivisionOptions;
	public uint ugcDefaultBeatDivision;
	public string simpleHintJsonPath;
	public string complexHintJsonPath;
	public uint noteCount;
	public ComboConfig[] comboConfig;
	public uint unlockTipsTextMapHash;
	public SoloConfig[] soloConfig;

	public class ComboConfig
	{
		public uint comboUpLimit;
		public float rate;
	}
	public class SoloConfig
	{
		public uint soloStart;
		public uint soloEnd;
		public bool isSelf;
	}
}