using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ScoreRule
{
	public string ruleName;
	public TriggerMode triggerMode;
	public string[] propertyNames;
	public int minSelectCount;
	public int maxSelectCount;
	public bool addToScoreView;
}