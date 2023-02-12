using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerAudio : ConfigAbilityAction
{
	public OpResponder responder;
	public ConfigAudioOperation operation;
}
