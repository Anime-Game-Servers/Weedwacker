using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigDither
{
	public float showDitherDuration;
	public ConfigDitherByStartDitherAction startDitherAction;
	public ConfigDitherByBetweenCameraAndAvatar betweenCameraAndAvatar;
	public ConfigDitherByNormalBetweenCamera normalBetweenCamera;
	public bool hideEffectWhenDither;

	public class ConfigDitherByStartDitherAction
	{
		public bool enable;
	}

	public class ConfigDitherByBetweenCameraAndAvatar
	{
		public float detectDitherRange;
	}

	public class ConfigDitherByNormalBetweenCamera
	{
		public float detectDitherRange;
	}
}
