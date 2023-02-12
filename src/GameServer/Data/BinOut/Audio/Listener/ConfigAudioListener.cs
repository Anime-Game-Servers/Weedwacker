using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioListener
{
	public float fakeAvatarDistance;
	public float akListenerHeight;
	public ConfigWwiseString obstructionRtpc;
	public ConfigWwiseString focusAngleRtpc;
	public float obstructionDetectRadius;
	public ConfigAudioListenerOutreachCast outreachCast;
	public float firstPersonListenerVolumeOffset;
	public float thirdPersonListenerVolumeOffset;
	public float defaultListenerVolumeOffset;

	public class ConfigAudioListenerOutreachCast
	{
		public float range;
		public float startAngle;
		public int rayCount;
		public ConfigWwiseString[] rtpcNames;
		public Vector offset;
	}
}