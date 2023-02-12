using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioEmitter
{
	public float emitterLifetime;
	public float emitInterval;
	public float instLifetime;
	public float endingDuration;
	public ConfigWwiseString emitEventName;
	public ConfigWwiseString endEventName;
	public AudioEmitterMultiPositionType multiPositionType;
}