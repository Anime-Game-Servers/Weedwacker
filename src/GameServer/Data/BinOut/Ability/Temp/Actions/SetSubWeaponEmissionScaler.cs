using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetSubWeaponEmissionScaler : ConfigAbilityAction
{
	public string[] subWeapons;
	public bool useDefaultColor;
	public float value;
	public float duration;
}