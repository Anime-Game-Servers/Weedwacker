using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class EnablePushColliderName : ConfigAbilityAction
{
	public object pushColliderNames; // string or string[]
	public bool setEnable;
}
