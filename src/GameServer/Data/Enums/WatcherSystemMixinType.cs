
namespace Weedwacker.GameServer.Data.Enums;

public enum WatcherSystemMixinType : int
{
	ElementReaction = 0,
	ElementReactionByWater = 1,
	ElementReactionByGrass = 2,
	ElementReactionByBush = 3,
	AttackLanded = 4,
	DoSkillSuccNomalAttack = 5,
	DoSkillSuccElementalArt = 6,
	DoSkillSuccElementalBurst = 7,
	ElementShieldAdd = 8,
	GlobalSubShieldAdd = 9,
	ListenAbilityAction = 10,
	LocalAvatarHPChange = 11,
	GetFirstWindBullet = 12,
	GetSecondWindBullet = 13,
	SpawnWindFieldByWindBullet = 14,
	AvatarStateIdChange = 15,
	AvatarWeaponElementOverride = 16,
	ListenAbilityStageAction
}