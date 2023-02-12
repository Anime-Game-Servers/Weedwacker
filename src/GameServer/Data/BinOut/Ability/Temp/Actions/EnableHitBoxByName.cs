using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class EnableHitBoxByName : ConfigAbilityAction
{
	public string[] hitBoxNames;
	public bool setEnable;
}
