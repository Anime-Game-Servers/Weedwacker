namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

internal class ThrowGrapplingHookMixin : ConfigAbilityMixin
{
	public string effectPattern;
	public string positionKey;
	public ConfigAbilityAction[] onHookReached;
}
