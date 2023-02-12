using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToSelfGlobalValueAndTalkStateNoInitMixin : AttachModifierToSelfGlobalValueNoInitMixin
{
	public object GVInTalk;
}
