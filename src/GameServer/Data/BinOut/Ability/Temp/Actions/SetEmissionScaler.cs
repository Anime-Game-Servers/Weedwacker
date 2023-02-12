using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetEmissionScaler : ConfigAbilityAction
{
	public BodyMaterialType materialType;
	public bool useDefaultColor;
	public float value;
	public float duration;
	public float emissionPower;
	public ColorVector emissionColor;
}
