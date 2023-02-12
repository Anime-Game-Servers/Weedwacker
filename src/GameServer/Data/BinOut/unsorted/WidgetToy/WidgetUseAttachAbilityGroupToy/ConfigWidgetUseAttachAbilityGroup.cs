using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetUseAttachAbilityGroup : ConfigBaseWidgetToy
{
	public string abilityGroupName;
	public string abilityGroupNameSecond;
	public uint sharedCdGroup;
	public WidgetSkillReplaceType[] replaceSkillHintList;
	public bool isUpdateCDAfterAbilityTrigger;
	public bool isSkipTakeOffAbilityGroupWhenChangeAvatar;
}