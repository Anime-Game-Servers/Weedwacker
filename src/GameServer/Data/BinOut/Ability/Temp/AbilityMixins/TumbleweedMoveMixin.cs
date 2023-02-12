namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

internal class TumbleweedMoveMixin : ConfigAbilityMixin
{
	//guessed types
	public float interval;
	public float tendToBornPosRadius;
	public float moveToBornPosRadius;
	public float attenuation;
	public float delay;
	public float downwardAccTime;
	public float downwardAcc;
	public ConfigAbilityAction[] onDirectionChanged;
	public ConfigAbilityAction[] onStartMove;
	public ConfigAbilityAction[] onStopMove;
}
