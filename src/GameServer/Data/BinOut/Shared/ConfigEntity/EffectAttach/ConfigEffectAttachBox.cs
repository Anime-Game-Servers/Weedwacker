using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigEffectAttach;

public class ConfigEffectAttachBox : ConfigEffectAttachShape
{
	public ParticleShapeType emitFrom;
	public float scaleX;
	public float scaleY;
	public float scaleZ;
}
