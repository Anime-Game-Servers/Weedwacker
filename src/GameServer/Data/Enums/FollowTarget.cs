
namespace Weedwacker.GameServer.Data.Enums;

public enum FollowTarget : int
{
	LocalAvatar = 0,
	LocalAvatarSyncedLocation = 1,
	LocalAvatarAuthority = 2,
	TargetEntity = 3,
	GroupGadgetEntity = 4,
	GroupMonsterEntity = 5,
	NpcEntity = 6,
}