using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioAvatarMove
{
	public ConfigWwiseString flyDirectionRtpcKey;
	public float flyDirectionRtpcFront;
	public float flyDirectionRtpcSide;
	public float flyDirectionRtpcBack;
	public float flyDirectionRtpcDrop;
	public ConfigWwiseString lastFrameSpeedInAirRtpcKey;
	public ConfigWwiseString eventFallInWater;
	public ConfigWwiseString altitudeRtpcKey;
	public ConfigWwiseString slopeRtpcKey;
	public ConfigWwiseString flyTurnEvent;
	public float flyTurnEventInterval;
	public ConfigWwiseString flySpeedRtpcKey;
	public float airflowSpeedGain;
	public float airflowGainFadeLength;
	public ConfigWwiseString climbVerticalScalerRtpcKey;
	public ConfigWwiseString climbVerticalScalerAnimatorKey;
	public ConfigWwiseString cameraAngleXRtpcKey;
	public ConfigWwiseString cameraAngleYRtpcKey;
	public ConfigWwiseString enterSpeedupFieldEvent;
	public ConfigWwiseString fallOnWaterRtpcKey;
}