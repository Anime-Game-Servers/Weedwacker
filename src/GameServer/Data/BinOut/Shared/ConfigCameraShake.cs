using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigCameraShake
{
	public CameraShakeType shakeType;
	public float shakeRange;
	public float shakeTime;
	public float shakeDistance;
	public Vector shakeDir;
	public ConfigCameraShakeExt extension;

	public class ConfigCameraShakeExt
	{
		public bool infinity;
		public bool baseOnCamera;
		public bool afterShake;
		public float baseCycle;
		public float cycleDamping;
		public float rangeAttenuation;
	}
}