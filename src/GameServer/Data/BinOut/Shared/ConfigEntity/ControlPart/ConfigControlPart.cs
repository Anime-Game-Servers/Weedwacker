using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigControlPart
{
	public float angularSpeed;
	public string partRootName;
	public ControlPartForwardBy forwardBy;
	public Vector forwardAxialFix;
	public ControlPartRotateBy rotateBy;
	public ControlPartDoOnUnEnabled doOnUnEabled;
	public string forwardByTransName;
	public float limitHorizontal;
	public float limitVertical;
	public ControlPartTargetType targetType;
}