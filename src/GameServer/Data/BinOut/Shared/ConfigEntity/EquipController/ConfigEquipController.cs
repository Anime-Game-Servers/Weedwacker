
namespace Weedwacker.GameServer.Data;

public class ConfigEquipController : ConfigBaseEquipController
{
	public Dictionary<string, string> attachPoints;
	public WeaponAwayFromHandState[] weaponAwayFromHandStates;

	public class WeaponAwayFromHandState
	{
		public string state;
		public float startNormTime;
		public float endNormTime;
		public float delayAppearTime;
		public float dissolveShowTime;
		public float dissolveHideTime;
	}
}