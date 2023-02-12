using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

namespace Weedwacker.GameServer.Data;

public class ConfigVehicleAudio : ConfigGadgetAudio
{
	public ConfigWwiseString collisionEvent;
	public float maxVelocity;
	public uint collisionAudioTriggerCooldown;
	public float collisionAudioTriggerThreshold;
}