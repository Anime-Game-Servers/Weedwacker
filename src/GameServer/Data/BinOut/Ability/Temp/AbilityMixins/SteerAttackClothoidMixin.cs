namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

internal class SteerAttackClothoidMixin : ConfigAbilityMixin
{
	public string[] steerStateIDs;
	public float startNormalizedTime;
	public float endNormalizedTime;
	public string attackTrigger;
	public float attackDistance;
	public bool remoteSteerToLocalTarget;
}
