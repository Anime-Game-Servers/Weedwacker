using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class PlayEmoSync : ConfigAbilityAction
{
	public uint dialogID;
	public string emoSyncAssetPath;
}
