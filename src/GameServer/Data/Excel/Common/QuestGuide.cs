using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel.Common;

public class QuestGuide
{
	public QuestGuideType type;
	public QuestGuideAuto autoGuide;
	public string[] param;
	public uint guideScene;
	public QuestGuideStyle guideStyle;
	public QuestGuideLayer guideLayer;
}
