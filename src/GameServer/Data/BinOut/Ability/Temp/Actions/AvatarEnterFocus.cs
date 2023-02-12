using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AvatarEnterFocus : ConfigAbilityAction
{
	public Vector cameraFollowLower;
	public Vector cameraFollowUpper;
	public float cameraFollowMaxDegree;
	public float cameraFollowMinDegree;
	public bool cameraFastFocusMode;
	public bool faceToTarget;
	public float faceToTargetAngleThreshold;
	public bool changeMainSkillID;
	public string dragButtonName;
	public FocusAssistanceGroup assistance;
	public bool canMove;
	public bool showCrosshair;
	public float vcam_fov;
	public float focusAnchorHorAngle;
	public float focusAnchorVerAngle;
	public bool disableAnim;
	public bool disableAimLayer;

	public class FocusAssistanceGroup
	{
		public FocusAssistance ps4;
		public FocusAssistance ps5;
		public FocusAssistance other;

		public class FocusAssistance
		{
			public bool useFocusSticky;
			public bool useAutoFocus;
			public bool useGyro;
		}
	}
}
