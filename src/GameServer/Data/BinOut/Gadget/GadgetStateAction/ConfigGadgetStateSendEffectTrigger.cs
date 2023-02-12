using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGadgetStateSendEffectTrigger : ConfigGadgetStateAction
{
	public string parameter;
	public AnimatorParamType type;
	public int value;
	public string effectPattern;
}