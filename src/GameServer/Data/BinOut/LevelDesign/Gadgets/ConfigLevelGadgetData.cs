using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelGadgetData
{
	public uint sceneId;
	public LevelGadget[] gadgets;

	public class LevelGadget
	{
		public uint groupId;
		public uint mapInstId;
		public string followMove_AttachPoint;
		public uint followMove_targetInstanceId;
		public bool gadgetMisc_UnlockShowCutScene;
		public ChestShowMoment gadgetMisc_ChestShowMoment;
		public ChestShowUIRemind gadgetMisc_ChestShowUIRemind;
		public ChestShowCutsceneType gadgetMisc_ChestShowCtsType;
		public bool billboard_HasUIBar;
		public float billboard_ShowUIBarDis;
		public float billboard_HideUIBarDis;
		public bool billboard_UIBarNeedEnterCombat;
		public HpBarStyle billboard_HpBarStyle;
		public TargetIndicatorType targetIndicator_Type;
		public ConfigTemplateData ui_Indicator;
		public uint targetIndicator_TaskID;
		public uint billboard_MultiBarSortId;
		public uint billboard_MultiBarNum;
		public ConfigTriggerOverride trigger;
		public Vector followRotateOffset;
		public Vector followRotateForwardOfffset;
		public Dictionary<uint, string> entityToManeuverCityMap;
		public string rotateCoreCityName;

		public class ConfigTriggerOverride
		{
			public bool overrideTriggerFlag;
			public TriggerFlag triggerFlag;
			public bool overrideCheckCount;
			public short checkCount;
			public bool overrideTriggerInterval;
			public float triggerInterval;
			public ConfigBaseShape rawShape;
			public bool overrideUseLocalTriggerLogic;
			public bool useLocalTriggerLogic;
			public ConfigLocalTriggerMeta localTriggerMeta;
		}
	}
}