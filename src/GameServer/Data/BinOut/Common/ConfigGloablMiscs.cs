using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGloablMiscs
{
	public float airFlowAcc;
	public uint paimonGadgetID;
	public string cureEffect;
	public ConfigAvatarFocusGroup avatarFocus;
	public string gadgetUICutSenceCfgPath;
	public string gadgetUICameraLookCfgPath;
	public string weaponAnimCurvePath;

	public class ConfigAvatarFocusGroup
	{
		public ConfigAvatarFocus ps4;
		public ConfigAvatarFocus ps5;
		public ConfigAvatarFocus pc;
		public ConfigAvatarFocus other;

		public class ConfigAvatarFocus
		{
			public float cameraHorMoveSpeed;
			public float cameraVerMoveSpeed;
			public float cameraHorStickyRatio;
			public float cameraVerStickyRatio;
			public float autoFocusHorSpeed;
			public float autoFocusVerSpeed;
			public float autoFocusRangeCoef;
			public float gyroHorMoveSpeed;
			public float gyroVerMoveSpeed;
		}
	}
}