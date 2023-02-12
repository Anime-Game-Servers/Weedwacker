using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AvatarSteerByCameraMixin : ConfigAbilityMixin
{
	public string[] stateIDs;
	public float angularSpeed;
	public bool canReviveStamina;
	public bool isCheckOnAttach;
}
