using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public abstract class ConfigBaseAttackPattern
{
	public TriggerType triggerType;
	public CheckHitLayerType checkHitLayerType;
	public ConfigHitScene hitScene;
	public float triggerCD;
	public bool filterByFrame;
	public bool ignoreMassive;
	public EntityAttackFilter entityAttackFilter;
	public float massiveAttackRatio;
	public ConfigBornType born;
}
