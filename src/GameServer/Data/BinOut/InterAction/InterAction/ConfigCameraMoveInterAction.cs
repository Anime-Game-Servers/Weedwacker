using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCameraMoveInterAction : ConfigBaseInterAction
{
	public StoryCameraPosType cameraPosType;
	public Vector camPosOffset;
	public float nearLength;
	public StoryCameraTargetType camTargetType;
	public Vector camForwardTargetOffset;
	public bool needElev;
	public float camFov;
	public float camDutch;
	public float lerpRatio;
	public int lerpPattern;
	public TweenEaseType cameraBlendType;
	public bool storyDither;
	public ConfigFrameTransition cutFrameTrans;
	public bool needZAxisRotate;
	public float rotateAngle;
	public bool openCameraDither;
	public string targetNpcAlias;
	public bool keepCameraPos;
	public bool useDurationWhenExitFocus;
	public bool closeTreeLeafDither;
	public string[] multiTargetNpcAliasArray;
	public bool closeCameraDisplacement;
	public VegetationInteractType vegInteractType;

	public class ConfigFrameTransition
	{
		public bool enable;
		public float duration;
	}
}