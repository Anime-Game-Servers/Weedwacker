using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("DungeonExcelConfigData.json")]
public class DungeonData
{
	public uint id;
	public ulong nameTextMapHash;
	public ulong displayNameTextMapHash;
	public ulong descTextMapHash;
	public DungeonType type;
	public DungeonSubType subType;
	public bool isDynamicLevel;
	public uint serialId;
	public DungeonPlayType playType;
	public uint sceneId;
	public uint eventInterval;
	public InvolveType involveType;
	public uint showLevel;
	public uint avatarLimitType;
	public uint limitLevel;
	public int levelRevise;
	public uint prevDungeonId;
	public uint requireAvatarId;
	public uint passCond;
	public uint passJumpDungeon;
	public uint reviveIntervalTime;
	public uint reviveMaxCount;
	public uint dayEnterCount;
	public IdCountConfig[] enterCostItems;
	public uint firstPassRewardPreviewID;
	public uint passRewardPreviewID;
	public uint settleCountdownTime;
	public uint failSettleCountdownTime;
	public uint quitSettleCountdownTime;
	public SettleShowType[] settleShows;
	public bool forbiddenRestart;
	public SettleUIType settleUIType;
	public uint statueCostID;
	public uint statueCostCount;
	public uint statueDrop;
	public ElementType[] recommendElementTypes;
	public string[] recommendTips;
	public Dictionary<uint, uint> levelConfigMap;
	public uint[] previewMonsterList;
	public uint gearDescTextMapHash;
	public uint cityID;
	public bool dontShowPushTips;
	public string entryPicPath;
	public DungeonStateType stateType;
	public string factorPic;
	public string factorIcon;
	public bool enableQuestGuide;
}
