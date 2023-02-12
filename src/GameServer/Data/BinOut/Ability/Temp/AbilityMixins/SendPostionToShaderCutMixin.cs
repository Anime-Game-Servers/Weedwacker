using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class SendPostionToShaderCutMixin : ConfigAbilityMixin
{
	public AbilityTargetting sendTarget;
	public float sendRadius;
	public Vector scale;
	public Vector offset;
}
