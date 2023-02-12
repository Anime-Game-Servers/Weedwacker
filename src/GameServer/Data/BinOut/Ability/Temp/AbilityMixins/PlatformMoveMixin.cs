using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class PlatformMoveMixin : ConfigAbilityMixin
{
	public bool isLogicMove;
	public string[] moveModifiers;
	public string[] stopModifiers;
}
