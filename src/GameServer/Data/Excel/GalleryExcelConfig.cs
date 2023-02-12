using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GalleryExcelConfig
{
	public uint id;
	public GalleryType type;
	public string[] param;
	public bool isEnableSinglePrepare;
	public uint singlePrepareTime;
	public bool isEnableMpPrepare;
	public uint mpPrepareTime;
	public bool isPermitInputInPrepare;
	public bool canInterruptByClient;
	public uint sceneId;
	public uint controlGroupId;
	public uint[] groupId;
	public uint groupFurnitureId;
	public uint revivePointGroupId;
	public uint revivePointConfigId;
	public string abilityGroup;
	public string[] abilityGroupList;
	public string limitRegion;
	public uint centerSceneId;
	public float[] centerPosList;
	public uint centerRadius;
	public uint duration;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public uint galleryNameTextMapHash;
	public uint galleryMSGTextMapHash;
	public string pic;
	public uint targetTextMapHash;
	public string startAudioValues;
	public string endAudioValues;
	public string[] selectable_ability_groups;
	public string[] teamAbilityGroupList;
	public string[] selectableTeamAbilityGroupList;
	public bool isDisableGroupDefaultReviseLevel;
}