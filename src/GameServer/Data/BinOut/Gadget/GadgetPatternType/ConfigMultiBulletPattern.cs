using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType;

public class ConfigMultiBulletPattern : ConfigBulletPattern
{
	public ConfigMultiBullet multiBulletConfig;
}

public class ConfigMultiBullet
{
	public SelectTargetDefaultType selectTargetDefaultType;
}

public class ConfigEffectItanoCircusBullet : ConfigMultiBullet
{
	public string effectPattern;
}